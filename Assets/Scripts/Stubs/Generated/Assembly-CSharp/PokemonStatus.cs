/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.ability;
using Const.creature;
using Const.fixed_creature;
using Const.item;
using Const.order;
using Const.pokemon;
using Const.sugowaza;
using Const.waza;
using TalkConst;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonStatus : StatusBase, IPokemonStatus // TypeDefIndex: 5197
{
	// Fields
	private const int DUMMY_VALUE = 999; // Metadata: 0x006110B8
	private Const.creature.Index[] deokishisuIndexArray; // 0x20

	// Nested types
	public class MenuParameter // TypeDefIndex: 5198
	{
		// Fields
		public int nHp; // 0x10
		public int nMaxHp; // 0x14
		public int nAtk; // 0x18
		public int nDfd; // 0x1C
		public int nExAtk; // 0x20
		public int nExDfd; // 0x24
		public int nSubayasa; // 0x28
		public bool bHpPinch; // 0x2C
		public bool bMaxHpUp; // 0x2D
		public bool bAtkUp; // 0x2E
		public bool bDfdUp; // 0x2F
		public bool bExAtkUp; // 0x30
		public bool bExDfdUp; // 0x31
		public bool bSubayasaUp; // 0x32

		// Constructors
		public MenuParameter() {} // 0x00C51F40-0x00C51F50

		// Methods
		public void GetParameter(StatusBase status) {} // 0x00C51D50-0x00C51F40
	}

	// Constructors
	public PokemonStatus() {} // Dummy constructor
	public PokemonStatus(ulong nativePointerId, uint nativeUnitqueId) {} // 0x00C4BCD0-0x00C4BD60

	// Methods
	public static PokemonStatus SetupRewardPokemonStatus(Const.creature.Index index, int lv, Const.sugowaza.Index sugowaza) => default; // 0x00C4BB40-0x00C4BCD0
	public static PokemonStatus SetupRewardPokemonStatusFromFixedCreatureParameter(Const.creature.Index index, Const.fixed_creature.Index fixedCreatureIndex) => default; // 0x00C4BE00-0x00C4BF10
	public static PokemonStatus SetupRewardPokemonStatusFormFixedPokemon(FixedWarehouseId wid) => default; // 0x00C4BF10-0x00C4C010
	public static PokemonStatus SetupTemporaryNukeninStatus(PokemonStatus baseStatus) => default; // 0x00C4C010-0x00C4C160
	public virtual bool IsEnable() => default; // 0x00C4C160-0x00C4C1F0
	public virtual bool IsStandBy() => default; // 0x00C4C1F0-0x00C4C280
	public virtual Const.creature.Index GetIndex() => default; // 0x00C4C280-0x00C4C310
	public virtual void SetIndex(Const.creature.Index index) {} // 0x00C4C310-0x00C4C3B0
	public PokemonWarehouseId GetWarehouseId() => default; // 0x00C4C3B0-0x00C4C470
	public void SetWarehouseId(PokemonWarehouseId whId) {} // 0x00C4C470-0x00C4C520
	public string GetName() => default; // 0x00C4C520-0x00C4C660
	public void SetName(string pName) {} // 0x00C4C660-0x00C4C700
	public int GetBookId() => default; // 0x00C4C700-0x00C4C7E0
	public int GetBookSortId() => default; // 0x00C4C7E0-0x00C4C8C0
	public int GetHonkeKindNo() => default; // 0x00C4C8C0-0x00C4C9A0
	public int GetHp() => default; // 0x00C4C9A0-0x00C4CA30
	public void SetHpMax() {} // 0x00C4CA30-0x00C4CAC0
	public int GetMaxHp() => default; // 0x00C4CAC0-0x00C4CB50
	public int SetMaxHp(int value) => default; // 0x00C4CB50-0x00C4CBF0
	public int GetPureMaxHp() => default; // 0x00C4CBF0-0x00C4CC80
	public int GetAddMaxHpValue(int index) => default; // 0x00C4CC80-0x00C4CD20
	public int GetBelly() => default; // 0x00C4CD20-0x00C4CDB0
	public void SetMaxBelly(int value) {} // 0x00C4CDB0-0x00C4CE50
	public int GetMaxBelly() => default; // 0x00C4CE50-0x00C4CEE0
	public int GetLevel() => default; // 0x00C4CEE0-0x00C4CF70
	public void ChangeLevel(int level) {} // 0x00C4CF70-0x00C4D010
	public int GetExperience() => default; // 0x00C4D010-0x00C4D0A0
	public int AddExperience(int addExp) => default; // 0x00C4D0A0-0x00C4D140
	public int GetExperienceNextLevel() => default; // 0x00C4D140-0x00C4D1D0
	public Const.waza.Index GetWaza(int id) => default; // 0x00C4D1D0-0x00C4D270
	public int GetWazaCount() => default; // 0x00C4D270-0x00C4D300
	public GenderType GetGender() => default; // 0x00C4D300-0x00C4D390
	public void SetGender(GenderType gender) {} // 0x00C4D390-0x00C4D430
	public int GetAttack(bool bOriginal = false /* Metadata: 0x006110AA */) => default; // 0x00C4D430-0x00C4D4D0
	public int SetAttack(int value, bool bOriginal = true /* Metadata: 0x006110AB */) => default; // 0x00C4D4D0-0x00C4D580
	public int GetDefense(bool bOriginal = false /* Metadata: 0x006110AC */) => default; // 0x00C4D580-0x00C4D620
	public int SetDefense(int value, bool bOriginal = true /* Metadata: 0x006110AD */) => default; // 0x00C4D620-0x00C4D6D0
	public int GetExAttack(bool bOriginal = false /* Metadata: 0x006110AE */) => default; // 0x00C4D6D0-0x00C4D770
	public int SetExAttack(int value, bool bOriginal = true /* Metadata: 0x006110AF */) => default; // 0x00C4D770-0x00C4D820
	public int GetExDefense(bool bOriginal = false /* Metadata: 0x006110B0 */) => default; // 0x00C4D820-0x00C4D8C0
	public int SetExDefense(int value, bool bOriginal = false /* Metadata: 0x006110B1 */) => default; // 0x00C4D8C0-0x00C4D970
	public int GetSubayasa(bool bOriginal = false /* Metadata: 0x006110B2 */) => default; // 0x00C4D970-0x00C4DA10
	public int SetSubayasa(int value, bool bOriginal = true /* Metadata: 0x006110B3 */) => default; // 0x00C4DA10-0x00C4DAC0
	public int GetNajimi() => default; // 0x00C4DAC0-0x00C4DB50
	public int GetAttackLevel() => default; // 0x00C4DB50-0x00C4DBE0
	public int GetExAttackLevel() => default; // 0x00C4DBE0-0x00C4DC70
	public int GetDefenseLevel() => default; // 0x00C4DC70-0x00C4DD00
	public int GetExDefenseLevel() => default; // 0x00C4DD00-0x00C4DD90
	public int GetHitLevel() => default; // 0x00C4DD90-0x00C4DE20
	public int GetDodgeLevel() => default; // 0x00C4DE20-0x00C4DEB0
	public float GetAttackMagnification() => default; // 0x00C4DEB0-0x00C4DF40
	public float GetExAttackMagnification() => default; // 0x00C4DF40-0x00C4DFD0
	public float GetDefenseMagnification() => default; // 0x00C4DFD0-0x00C4E060
	public float GetExDefenseMagnification() => default; // 0x00C4E060-0x00C4E0F0
	public string GetWazaName(Const.waza.Index index, bool bGrade = true /* Metadata: 0x006110B4 */, bool bColor = true /* Metadata: 0x006110B5 */) => default; // 0x00C4E0F0-0x00C4E250
	public void SetWazaPP(Const.waza.Index wazaIndex, int value) {} // 0x00C4E250-0x00C4E300
	public int GetWazaPP(Const.waza.Index wazaIndex) => default; // 0x00C4E300-0x00C4E3A0
	public int GetWazaPPMax(Const.waza.Index wazaIndex) => default; // 0x00C4E3A0-0x00C4E440
	public Const.pokemon.Type GetType(int typeIndex) => default; // 0x00C4E440-0x00C4E4E0
	public Const.ability.Index GetAbility(bool bOriginal = false /* Metadata: 0x006110B6 */) => default; // 0x00C4E4E0-0x00C4E580
	public int GetAbilityIndex() => default; // 0x00C4E580-0x00C4E610
	public void SetSugowaza(Const.sugowaza.Index sugowaza) {} // 0x00C4BD60-0x00C4BE00
	public void SetAbility(Const.ability.Index ability) {} // 0x00C4E610-0x00C4E6B0
	public Const.sugowaza.Index GetSugowaza() => default; // 0x00C4E6B0-0x00C4E740
	public void SetSugowaza(int sugowazaIndex) {} // 0x00C4E740-0x00C4E7E0
	public bool IsFavor() => default; // 0x00C4E7E0-0x00C4E870
	public bool IsEnableWaza(int id) => default; // 0x00C4E870-0x00C4E910
	public void SetEnableWaza(int id, bool set) {} // 0x00C4E910-0x00C4E9C0
	public void UpdateSupportNpcUsed() {} // 0x00C4E9C0-0x00C4EA50
	public bool IsWazaRenketsuParent(int wazaStatusId) => default; // 0x00C4EA50-0x00C4EAF0
	public bool IsWazaRenketsuChild(int wazaStatusId) => default; // 0x00C4EAF0-0x00C4EB90
	public int GetWazaRenketsuChildValue(int wazaStatusId) => default; // 0x00C4EB90-0x00C4EC30
	public int GetWazaRenketsuParentValue(int wazaStatusId) => default; // 0x00C4EC30-0x00C4ECD0
	public List<int> GetWazaRenketsuList(int wazaStatusId) => default; // 0x00C4ECD0-0x00C4EE50
	public void SetWazaRenketsu(int wazaStatusIdParent, int wazaStatusIdChild) {} // 0x00C4EE50-0x00C4EF00
	public void RemoveWazaRenketsu(int wazaStatusId) {} // 0x00C4EF00-0x00C4EFA0
	public List<WazaRememberParameter> GetWazaRememberList() => default; // 0x00C4EFA0-0x00C4F1A0
	public List<WazaRememberParameter> GetWazaRememberListWithLevelFilter() => default; // 0x00C4F1A0-0x00C4F3A0
	public List<WazaForgetParameter> GetWazaForgetList() => default; // 0x00C4F3A0-0x00C4F5A0
	public List<WazaOshieParameter> GetWazaOshieList() => default; // 0x00C4F5A0-0x00C4F790
	private List<WazaRememberParameter> GetWazaRememberList(Const.creature.Index pokemonIndex, int level) => default; // 0x00C4F790-0x00C4F970
	private List<WazaOshieParameter> GetWazaOshieList(Const.creature.Index pokemonIndex) => default; // 0x00C4F970-0x00C4FB30
	private List<WazaRememberParameter> GetWazaRememberList_DEOKISHISU(int level) => default; // 0x00C4FB30-0x00C4FDC0
	private List<WazaOshieParameter> GetWazaOshieList_DEOKISHISU(int level) => default; // 0x00C4FDC0-0x00C50030
	public List<WazaOshieParameter> GetWazaOshieList_General() => default; // 0x00C50030-0x00C50100
	public List<WazaRememberParameter> GetWazaRememberList_General() => default; // 0x00C50100-0x00C50790
	public void SetWaza(int wazaListIndex, Const.waza.Index wazaIndex) {} // 0x00C50790-0x00C50840
	public void ClearWaza(int wazaListIndex) {} // 0x00C50840-0x00C508E0
	public void SwapWaza(int wazaStatusIdA, int wazaStatusIdB) {} // 0x00C508E0-0x00C50990
	public bool AddWaza(Const.waza.Index wazaIndex) => default; // 0x00C50990-0x00C50A30
	public IItem GetEquippedItem() => default; // 0x00C50A30-0x00C50C20
	public Const.order.Index GetOrderIndex() => default; // 0x00C50C20-0x00C50CB0
	public void SetOrderIndex(Const.order.Index orderIndex) {} // 0x00C50CB0-0x00C50D50
	public bool CanAddParty() => default; // 0x00C50D50-0x00C50DE0
	public Const.creature.Index GetHistoryEvolutionPokemon(int historyIndex) => default; // 0x00C50DE0-0x00C50E80
	public int GetHistoryEvolutionLevel(int historyIndex) => default; // 0x00C50E80-0x00C50F20
	public Const.creature.Index GetEvolutionPokemonIndex(int infoNum) => default; // 0x00C50F20-0x00C50FC0
	public int GetEvolutionInfoNum() => default; // 0x00C50FC0-0x00C51210
	public int GetEvolutionLevel(int infoNum) => default; // 0x00C51210-0x00C512B0
	public bool IsUsedEvolutionItem(int infoNum) => default; // 0x00C512B0-0x00C51340
	public Const.item.Index GetEvolutionItem(int infoNum) => default; // 0x00C51340-0x00C513D0
	public int GetEvolutionItemNum(int infoNum) => default; // 0x00C513D0-0x00C51460
	public bool CanEvolution() => default; // 0x00C51460-0x00C514F0
	public bool CanEvolution(int infoNum) => default; // 0x00C514F0-0x00C51590
	public int EvolutionDecision(ushort wId, Const.creature.Index evoIndex) => default; // 0x00C51590-0x00C51640
	public int EvolutionDecision(IPokemonWarehouseStatus wStatus, Const.creature.Index nextIndex) => default; // 0x00C51640-0x00C51850
	public void SetEvolutionLevel(int level) {} // 0x00C51850-0x00C518F0
	public TextIDHash GetPokemonTalkMessage(Scene scene, bool bBossScene = false /* Metadata: 0x006110B7 */) => default; // 0x00C518F0-0x00C519A0
	public bool IsLearnWazamachine(Const.item.Index itemIndex) => default; // 0x00C519A0-0x00C51A40
	public void SetDungeonCameraForcus() {} // 0x00C51A40-0x00C51AD0
	public void UpdateStatusMYUU(IPokemonStatus updateStatus) {} // 0x00C51AD0-0x00C51BD0
	public bool IsNotPartedMember() => default; // 0x00C51BD0-0x00C51C30
	public int GetFriendSortId() => default; // 0x00C51C30-0x00C51CC0
}

