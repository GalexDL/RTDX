/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.ability;
using Const.creature;
using Const.item;
using Const.order;
using Const.pokemon;
using Const.sugowaza;
using Const.waza;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IPokemonStatus // TypeDefIndex: 5073
{
	// Methods
	bool IsEnable();
	bool IsStandBy();
	Const.creature.Index GetIndex();
	void SetIndex(Const.creature.Index index);
	PokemonWarehouseId GetWarehouseId();
	void SetWarehouseId(PokemonWarehouseId id);
	string GetName();
	void SetName(string pName);
	int GetBookId();
	int GetBookSortId();
	int GetHonkeKindNo();
	int GetHp();
	int GetMaxHp();
	int GetPureMaxHp();
	int GetAddMaxHpValue(int index);
	int GetBelly();
	void SetMaxBelly(int value);
	int GetMaxBelly();
	int GetLevel();
	void ChangeLevel(int level);
	int GetExperience();
	int AddExperience(int addExp);
	int GetExperienceNextLevel();
	Const.waza.Index GetWaza(int id);
	int GetWazaCount();
	GenderType GetGender();
	void SetGender(GenderType gender);
	int SetMaxHp(int value);
	void SetHpMax();
	int GetAttack(bool bOriginal = false /* Metadata: 0x00610EBA */);
	int SetAttack(int value, bool bOriginal = true /* Metadata: 0x00610EBB */);
	int GetDefense(bool bOriginal = false /* Metadata: 0x00610EBC */);
	int SetDefense(int value, bool bOriginal = true /* Metadata: 0x00610EBD */);
	int GetExAttack(bool bOriginal = false /* Metadata: 0x00610EBE */);
	int SetExAttack(int value, bool bOriginal = true /* Metadata: 0x00610EBF */);
	int GetExDefense(bool bOriginal = false /* Metadata: 0x00610EC0 */);
	int SetExDefense(int value, bool bOriginal = true /* Metadata: 0x00610EC1 */);
	int GetSubayasa(bool bOriginal = false /* Metadata: 0x00610EC2 */);
	int SetSubayasa(int value, bool bOriginal = true /* Metadata: 0x00610EC3 */);
	int GetNajimi();
	int GetAttackLevel();
	int GetExAttackLevel();
	int GetDefenseLevel();
	int GetExDefenseLevel();
	int GetHitLevel();
	int GetDodgeLevel();
	float GetAttackMagnification();
	float GetExAttackMagnification();
	float GetDefenseMagnification();
	float GetExDefenseMagnification();
	string GetWazaName(Const.waza.Index index, bool bGrade = true /* Metadata: 0x00610EC4 */, bool bColor = true /* Metadata: 0x00610EC5 */);
	void SetWazaPP(Const.waza.Index wazaIndex, int value);
	int GetWazaPP(Const.waza.Index index);
	int GetWazaPPMax(Const.waza.Index index);
	Const.pokemon.Type GetType(int index);
	Const.ability.Index GetAbility(bool bOriginal = false /* Metadata: 0x00610EC6 */);
	int GetAbilityIndex();
	Const.sugowaza.Index GetSugowaza();
	void SetSugowaza(int sugowazaIndex);
	bool IsFavor();
	bool IsEnableWaza(int id);
	void SetEnableWaza(int id, bool enable);
	void UpdateSupportNpcUsed();
	int GetWazaRenketsuChildValue(int wazaStatusId);
	int GetWazaRenketsuParentValue(int wazaStatusId);
	bool IsWazaRenketsuParent(int wazaStatusId);
	bool IsWazaRenketsuChild(int wazaStatusId);
	List<int> GetWazaRenketsuList(int wazaStatusId);
	void SetWazaRenketsu(int wazaStatusIdParent, int wazaStatusIdChild);
	void RemoveWazaRenketsu(int wazaStatusId);
	List<WazaForgetParameter> GetWazaForgetList();
	List<WazaOshieParameter> GetWazaOshieList_General();
	List<WazaRememberParameter> GetWazaRememberList_General();
	void SetWaza(int wazaListIndex, Const.waza.Index wazaIndex);
	void ClearWaza(int wazaListIndex);
	void SwapWaza(int wazaStatusIdA, int wazaStatusIdB);
	IItem GetEquippedItem();
	Const.order.Index GetOrderIndex();
	void SetOrderIndex(Const.order.Index orderIndex);
	bool CanAddParty();
	Const.creature.Index GetHistoryEvolutionPokemon(int historyIndex);
	int GetHistoryEvolutionLevel(int historyIndex);
	Const.creature.Index GetEvolutionPokemonIndex(int infoNum);
	int GetEvolutionInfoNum();
	int GetEvolutionLevel(int infoNum);
	bool IsUsedEvolutionItem(int infoNum);
	bool CanEvolution(int infoNum);
	bool CanEvolution();
	int EvolutionDecision(ushort wId, Const.creature.Index evoIndex);
	int EvolutionDecision(IPokemonWarehouseStatus wStatus, Const.creature.Index nextIndex);
	Const.item.Index GetEvolutionItem(int infoNum);
	void SetEvolutionLevel(int level);
	int GetEvolutionItemNum(int infoNum);
	bool IsNotPartedMember();
	int GetFriendSortId();
}

