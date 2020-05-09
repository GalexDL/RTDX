/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Organization : Singleton<Organization> // TypeDefIndex: 5055
{
	// Fields
	private const int UNDEFINED_WAERHOUSE_ID = 65535; // Metadata: 0x00610DC8
	private const int PRESET_INDEX_MAX = 12; // Metadata: 0x00610DCC
	public const int PRESET_INDEX_FIX = 10; // Metadata: 0x00610DD0
	public const int PRESET_INDEX_TRAINING = 11; // Metadata: 0x00610DD4
	private OrganizationType type_; // 0x10
	private Const.dungeon.Index dgIndex_; // 0x14
	private bool bItemBagPulledOut_; // 0x18

	// Nested types
	public enum OrganizationType // TypeDefIndex: 5056
	{
		FREE = 0,
		HERO_PARTNER = 1,
		HERO_PARTNER_MEMBER = 2,
		HERO_PARTNER_ABUSORU = 3,
		EVENT_GENGAA = 4,
		MAX = 5,
		TRAINIG = 6
	}

	// Constructors
	public Organization() {} // 0x00788C40-0x00788CB0

	// Methods
	public static bool IsOrganizationPresetFix(int presetIndex) => default; // 0x00785FD0-0x00785FE0
	public static void SetOrganizationCurrentPresetIndex(int presetIndex) {} // 0x00785FE0-0x00786050
	public static int GetOrganizationCurrentPresetIndex() => default; // 0x00786050-0x007860C0
	public static int[] GetOrganizationPresetMembder(int presetIndex) => default; // 0x007860C0-0x007862C0
	public static void SetOrganizationPresetMember(int presetIndex, int memberId, int warehouseId, Const.creature.Index formIndex = Const.creature.Index.NONE /* Metadata: 0x00610DC4 */) {} // 0x007862C0-0x00786350
	public static void RemoveOrganizationPresetMember(int presetIndex, int memberId) {} // 0x00786350-0x007863D0
	public static Const.creature.Index GetOrganizationPresetMemberFormIndex(int presetIndex, int memberId) => default; // 0x007863D0-0x00786450
	public static bool IsFormChangePokemon(Const.creature.Index pokemonIndex) => default; // 0x00786450-0x00786460
	public static Const.creature.Index[] GetFromChangeList(Const.creature.Index pokemonIndex) => default; // 0x00786460-0x007864D0
	public static void UpdateOrganizationEquippedItem() {} // 0x007864D0-0x00786540
	public static IItem GetOrganizationEquippedItem(int equipId) => default; // 0x00786540-0x00786720
	public static void SetOrganizationEquippedItem(int equipId, uint itemUniqueId) {} // 0x00786720-0x007867D0
	public void SetupPartyOrganization() {} // 0x007867D0-0x00786EE0
	public static bool CheckGENGAA(string scenarioDgOrganizationSymbol, Const.dungeon.Index enterDungeon) => default; // 0x00786F70-0x00787020
	public static OrganizationType GetOrganizationType(string organizationSymbol) => default; // 0x00787020-0x007872F0
	public OrganizationType GetOrganizationType() => default; // 0x007872F0-0x00787300
	public OrganizationType InitPartyOrganization(string organizationSymbol, Const.dungeon.Index dgIndex) => default; // 0x00787300-0x007873C0
	public void ClearFixedPartyOrganization(bool bResetFreeMember) {} // 0x007873C0-0x00787C60
	private List<PokemonWarehouseId> _getLastPresetWIDs(int[] ids) => default; // 0x00787C60-0x00787E40
	public void OverwriteFixedPartyOrganization(int[] ids) {} // 0x00787E40-0x00788060
	public int GetPresetPartyOrganization() => default; // 0x00786EE0-0x00786F70
	public bool IsLockedPartyOrganization(int member) => default; // 0x00788060-0x007880D0
	public bool IsFixedPartyOrganization() => default; // 0x007880D0-0x007880E0
	public bool IsEventGENGAA() => default; // 0x007880E0-0x007880F0
	public Const.dungeon.Index GetDestination() => default; // 0x007880F0-0x00788100
	public OrganizationType InitTraningOrganization(PokemonWarehouseId wid, Const.dungeon.Index dgIndex, Const.creature.Index formIndex) => default; // 0x00788100-0x007882C0
	public bool SetupItemBag() => default; // 0x007882C0-0x007887A0
	public void AllSetOrganizationEquippedItem() {} // 0x007887A0-0x00788C10
	public void ResetItemPulledOut() {} // 0x00788C10-0x00788C20
	public void SetItemPulledOut() {} // 0x00788C20-0x00788C30
	public bool IsItemPulledOut() => default; // 0x00788C30-0x00788C40
}

