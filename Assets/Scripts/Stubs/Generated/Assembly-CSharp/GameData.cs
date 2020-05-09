/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.creature;
using Const.dungeon;
using Const.fixed_reward;
using Const.pokemon;
using Const.rank;
using kamina.graphics;
using Language;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GameData : Singleton<GameData> // TypeDefIndex: 4658
{
	// Fields
	private StatusBase temporaryGuestMember_; // 0x10
	public DummyDungeon dungeon; // 0x18
	private bool m_bDungeon; // 0x20
	public int QualityNo; // 0x24

	// Nested types
	public class AreaInfo // TypeDefIndex: 4659
	{
		// Fields
		public Const.dungeon.Index dungeonIndex; // 0x10
		public bool bScenario; // 0x14
		public bool bScenarioBoss; // 0x15
		public bool bClearFlag; // 0x16
		public int numArrivalFloor; // 0x18
		public bool bNewOpen; // 0x1C
		public int numRequest; // 0x20
		public int numRescue; // 0x24
		public int numInvalid; // 0x28
		public bool bRescueIcon; // 0x2C
		public int numFloor; // 0x30
		public int numMember; // 0x34
		public bool bLevelReset; // 0x38
		public bool bItemBring; // 0x39
		public bool bJoin; // 0x3A
		public bool bRescue; // 0x3B
		public Const.creature.Index superPokemonIndex; // 0x3C
		public bool bReliefDungeon; // 0x40
		public bool bBonusDungeon; // 0x41
		public int sortKey; // 0x44

		// Constructors
		public AreaInfo() {} // 0x00BB0EB0-0x00BB0EC0

		// Methods
		public virtual void Init(Const.dungeon.Index index) {} // 0x00BB0BE0-0x00BB0E40
		public virtual int GetSortKey() => default; // 0x00BB0E40-0x00BB0EB0
	}

	public class RequestInfo // TypeDefIndex: 4660
	{
		// Fields
		public Const.creature.Index CreatureIndex; // 0x10
		public GenderType Gender; // 0x14
		public string ClientName; // 0x18
		public string Purpose; // 0x20
		public int Floor; // 0x28

		// Constructors
		public RequestInfo() {} // 0x00BB0F70-0x00BB0F80
	}

	public class DummyDungeon // TypeDefIndex: 4661
	{
		// Fields
		public int PlayerDirection; // 0x10

		// Constructors
		public DummyDungeon() {} // 0x00BB0BD0-0x00BB0BE0

		// Methods
		public bool IsAutoLocked() => default; // 0x00BB0EC0-0x00BB0ED0
		public void CreatePopupHPGauge(float src_amount, float dst_amount, Vector3 arg_pos, ModelBase target) {} // 0x00BB0ED0-0x00BB0EE0
		public void HideTurnMarker() {} // 0x00BB0EE0-0x00BB0EF0
		public void ShowBossHPGauge(int hp, int maxhp, int damage, int effect, Vector3 arg_pos, ModelBase target, int[] pin) {} // 0x00BB0EF0-0x00BB0F00
		public void ShowBossOverDriveGauge(int hp, int maxhp, int damage, int effect, int rest_turn, Vector3 arg_pos, ModelBase target) {} // 0x00BB0F00-0x00BB0F10
		public void ClearPopupHPGauge() {} // 0x00BB0F10-0x00BB0F20
		public void HideBossHPGauge() {} // 0x00BB0F20-0x00BB0F30
		public void SetDispAllUI(bool active) {} // 0x00BB0F30-0x00BB0F40
		public void SetAgingInfo(string aging_text, int send_time) {} // 0x00BB0F40-0x00BB0F50
		public bool CheckNextFloorAnimation() => default; // 0x00BB0F50-0x00BB0F60
		public static implicit operator bool(DummyDungeon exists) => default; // 0x00BB0F60-0x00BB0F70
	}

	// Constructors
	public GameData() {} // 0x00BB0B40-0x00BB0BD0

	// Methods
	public void ChangeNormalMode() {} // 0x00BAD930-0x00BAD9A0
	public void ChangePerippaaMode() {} // 0x00BAD9A0-0x00BADA10
	public void ChangeKunrenMode() {} // 0x00BADA10-0x00BADA80
	public bool IsNormalMode() => default; // 0x00BADA80-0x00BADAF0
	public bool IsPerippaaMode() => default; // 0x00BADAF0-0x00BADB60
	public bool IsKunrenMode() => default; // 0x00BADB60-0x00BADBD0
	public int AddRankPoint(int point) => default; // 0x00BADBD0-0x00BADC40
	public int GetNextRankNecessaryPoint() => default; // 0x00BADC40-0x00BADCB0
	public int GetRankPoint(Const.rank.Index rank) => default; // 0x00BADCB0-0x00BADD20
	public int GetNowRankPoint() => default; // 0x00BADD20-0x00BADD90
	public Const.rank.Index GetNowRankIndex() => default; // 0x00BADD90-0x00BADE00
	public string GetNowRankName() => default; // 0x00BADE00-0x00BADF10
	public int GetNowPrisetNum() => default; // 0x00BADF10-0x00BADF80
	public int GetNowGeneralCampEntryNum() => default; // 0x00BADF80-0x00BADFF0
	public int GetPrisetNum(Const.rank.Index rank) => default; // 0x00BADFF0-0x00BAE060
	public int GetQuestTicketListMaxNum(Const.rank.Index rank) => default; // 0x00BAE060-0x00BAE0D0
	public int GetQuestTicketListMaxNumFromCurrentRank() => default; // 0x00BAE0D0-0x00BAE180
	public int GetItemBagNum(Const.rank.Index rank) => default; // 0x00BAE180-0x00BAE1F0
	public int GetGeneralCampEntryNum(Const.rank.Index rank) => default; // 0x00BAE1F0-0x00BAE260
	public string GetSekizouSymbol(Const.rank.Index rank) => default; // 0x00BAE260-0x00BAE3A0
	public Const.fixed_reward.Index GetFixedRewardIndex(Const.rank.Index rank) => default; // 0x00BAE3A0-0x00BAE410
	public Const.fixed_reward.Index GetFixedAchievedRewardIndex0(Const.rank.Index rank) => default; // 0x00BAE410-0x00BAE480
	public Const.fixed_reward.Index GetFixedAchievedRewardIndex1(Const.rank.Index rank) => default; // 0x00BAE480-0x00BAE4F0
	public int GetNowRescueCount() => default; // 0x00BAE4F0-0x00BAE560
	public bool CheckStatueUnlockRankPoint(string statueSymbol) => default; // 0x00BAE560-0x00BAE600
	public PartyMemberId GetPlayerMemberId() => default; // 0x00BAE600-0x00BAE680
	private List<IPartyStatus> readPartyList_() => default; // 0x00BAE680-0x00BAE820
	public List<IPartyStatus> GetPartyList() => default; // 0x00BAE820-0x00BAE8D0
	public List<IPartyStatus> GetPartyListModeNormal() => default; // 0x00BAE8D0-0x00BAE980
	public IPartyStatus GetPartyModeNormal(PokemonWarehouseId whId) => default; // 0x00BAE980-0x00BAEB60
	public List<IPartyStatus> GetPartyListModePerippaa() => default; // 0x00BAEB60-0x00BAEC10
	public IPartyStatus GetPartyModePerippaa(PokemonWarehouseId whId) => default; // 0x00BAEC10-0x00BAEDF0
	public List<IPokemonWarehouseStatus> GetPartyList_ForKyarageki() => default; // 0x00BAEDF0-0x00BAF230
	public List<Const.creature.Index> GetPartyListWithMega_ForKyarageki() => default; // 0x00BAF230-0x00BAF6F0
	public List<int> GetPartyMemberId() => default; // 0x00BAF6F0-0x00BAF880
	public PartyMemberId FindPartyMember(PokemonWarehouseId wid) => default; // 0x00BAF880-0x00BAFA70
	public void UpdatePartyPokemonStatusFromWarehouseStatus() {} // 0x00BAFA70-0x00BAFAE0
	public void AllRemovePartyMember(bool bFeedbackWarehouse) {} // 0x00BAFAE0-0x00BAFB50
	public void PartyMember_AddPartyMember(PokemonWarehouseId wId, bool bSetPlayer) {} // 0x00BAFB50-0x00BAFBE0
	public List<IPartyStatus> GetGuestList() => default; // 0x00BAFBE0-0x00BAFDC0
	public int GetGuestBonusCash(PartyMemberId memberId) => default; // 0x00BAFDC0-0x00BAFE40
	public void GuestMemberAllRemove() {} // 0x00BAFE40-0x00BAFEB0
	public bool IsGuestMember(IPokemonStatus status, bool bIncludeTemporary = false /* Metadata: 0x00610AB8 */) => default; // 0x00BAFEB0-0x00BB0280
	public void SetTemporaryGuestMember(StatusBase status) {} // 0x00BB0290-0x00BB02A0
	public void ClearTemporaryGuestMember() {} // 0x00BB02A0-0x00BB02B0
	public string GetDungeonName(Const.dungeon.Index dungeonIndex, DungeonNameType nameType = DungeonNameType.FULL_KANJI_RUBY /* Metadata: 0x00610AB9 */) => default; // 0x00BB02B0-0x00BB03D0
	public Const.creature.Index GetKyoutekiPokemon(Const.dungeon.Index dungeonIndex) => default; // 0x00BB03D0-0x00BB0440
	public void UpdateKyoutekiPokemonForNextDay() {} // 0x00BB0440-0x00BB04B0
	public Const.dungeon.Index GetBounusDungeonIndex() => default; // 0x00BB04B0-0x00BB0520
	public void UpdateBounusDungeonForNextDay() {} // 0x00BB0520-0x00BB0590
	public void UpdateOpenReliefDungeonPokemonForNextDay() {} // 0x00BB0590-0x00BB0600
	public int GetReliefDungeonOpenDaysLeft() => default; // 0x00BB0600-0x00BB0670
	public Language.Type GetLanguageType() => default; // 0x00BA9D90-0x00BA9E00
	public void ChangeLanguageType(Language.Type lang) {} // 0x00BB0670-0x00BB06E0
	public void RefreshLoadAheadPrefab() {} // 0x00BB06E0-0x00BB08A0
	public void SetPartyName(string name) {} // 0x00BB08A0-0x00BB0910
	public string GetPartyName() => default; // 0x00BB0910-0x00BB09C0
	public void SetUnlockOldDLCDungeon(bool bEnable) {} // 0x00BB09C0-0x00BB0A30
	public void SetDungeonPlayFlag(bool bEnable) {} // 0x00BB0A30-0x00BB0A40
	public bool IsDungeonPlay() => default; // 0x00BB0280-0x00BB0290
	public bool IsCircleShadowQuality() => default; // 0x00BB0A40-0x00BB0A50
	public bool IsBGEffectQuality() => default; // 0x00BB0A50-0x00BB0A60
	public void SetQualityNo(int qua_no, bool bForce = false /* Metadata: 0x00610ABD */) {} // 0x00BB0A60-0x00BB0A70
	public void SetDungeonSystemMessage(string msg) {} // 0x00BB0A70-0x00BB0A80
	public string GetDungeonName(int textId) => default; // 0x00BB0A80-0x00BB0AD0
	public object ReadCreatureDataInfo(Const.creature.Index index) => default; // 0x00BB0AD0-0x00BB0AE0
	public object ReadCreatureIndexList(int idx) => default; // 0x00BB0AE0-0x00BB0AF0
	public static Vector2 InitializeWindows() => default; // 0x00BB0AF0-0x00BB0B30
	public void Initialize() {} // 0x00BB0B30-0x00BB0B40
}

