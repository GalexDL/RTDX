/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.ability;
using Const.camp;
using Const.creature;
using Const.item;
using Const.order;
using Const.pokemon;
using Const.sugowaza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonDatabase // TypeDefIndex: 5195
{
	// Fields
	public static readonly int JIRAACHI_JOIN_NAKAMA_SUGOWAZA_TABLE_ID; // 0x00
	private static Color32[] typeColor; // 0x08

	// Constructors
	public PokemonDatabase() {} // 0x00C42580-0x00C42590
	static PokemonDatabase() {} // 0x00C42590-0x00C42B20

	// Methods
	public static uint GetGfxSymbol(Const.creature.Index creatureIndex, FormType form) => default; // 0x00C40BD0-0x00C40BE0
	public static string GetFaceFileName(Const.creature.Index index, FormType form) => default; // 0x00C40BE0-0x00C40C60
	public static string GetDotFileName(Const.creature.Index index, FormType form) => default; // 0x00C40C60-0x00C40CE0
	public static GraphicsSystem.CharacterDatabaseParameter GetCharacterParameter(Const.creature.Index index, FormType form) => default; // 0x00C40CE0-0x00C40D60
	public static EvolutionCameraType GetEvolutionCameraType(Const.creature.Index index, FormType form) => default; // 0x00C40D60-0x00C40E40
	public static string GetName(Const.creature.Index index) => default; // 0x00C40E40-0x00C40F00
	public static bool IsEnable(Const.creature.Index index) => default; // 0x00C40F00-0x00C40F70
	public static bool IsEnableFromGfxSymbol(uint gfxSymbol) => default; // 0x00C40F70-0x00C40FE0
	public static bool IsOrganization(Const.creature.Index index) => default; // 0x00C40FE0-0x00C41050
	public static bool IsJiraachiNegaigoto(Const.creature.Index index) => default; // 0x00C41050-0x00C410C0
	public static int GetBookId(Const.creature.Index index) => default; // 0x00C410C0-0x00C41130
	public static int GetBookSortId(Const.creature.Index index) => default; // 0x00C41130-0x00C411A0
	public static int GetHonkeKindNo(Const.creature.Index index) => default; // 0x00C411A0-0x00C41210
	public static Const.pokemon.Type GetType(Const.creature.Index index, int id) => default; // 0x00C41210-0x00C41290
	public static string GetTypeName(Const.pokemon.Type type) => default; // 0x00C41290-0x00C41350
	public static string GetTypeIconTag(Const.pokemon.Type type) => default; // 0x00C41350-0x00C41410
	public static Const.camp.Index GetCampIndex(Const.creature.Index creatureIndex) => default; // 0x00C41410-0x00C41480
	public static bool IsScenarioProgress(Const.creature.Index creatureIndex) => default; // 0x00C41480-0x00C414F0
	public static bool CanAddParty(Const.creature.Index creatureIndex) => default; // 0x00C414F0-0x00C41560
	public static bool CanAddPartyForShop(Const.creature.Index creatureIndex) => default; // 0x00C41560-0x00C415D0
	public static Color32 GetTypeColor(Const.pokemon.Type type) => default; // 0x00C415D0-0x00C41670
	public static string GetBookKindName(Const.creature.Index pokemonIndex) => default; // 0x00C41670-0x00C41730
	public static string GetAbilityName(Const.ability.Index pokemonAbility, bool bColor = true /* Metadata: 0x006110A7 */) => default; // 0x00C41730-0x00C41800
	public static string GetSugowazaName(Const.sugowaza.Index pokemonSugowaza, bool bColor = true /* Metadata: 0x006110A8 */, bool bIcon = true /* Metadata: 0x006110A9 */) => default; // 0x00C41800-0x00C418D0
	public static string GetOrderName(Const.order.Index pokemonOrder) => default; // 0x00C418D0-0x00C41990
	public static List<Const.creature.Index> GetOrganizationList() => default; // 0x00C41990-0x00C41AD0
	public static Const.creature.Index GetRetrogradeIndex(Const.creature.Index index) => default; // 0x00C41AD0-0x00C41B40
	public static int GetMinLevel(Const.creature.Index index) => default; // 0x00C41B40-0x00C41BB0
	public static int GetMinLevelForFriend(Const.creature.Index index) => default; // 0x00C41BB0-0x00C41C20
	public static Const.sugowaza.Index DrawingSugowaza(int index, float adjustRate) => default; // 0x00C41C20-0x00C41CA0
	public static Const.sugowaza.Index DrawingSugowaza(int index, float adjustRate, Const.sugowaza.Index nowSugowazaIndex) => default; // 0x00C41CA0-0x00C41E20
	public static bool IsRareColor(Const.creature.Index index) => default; // 0x00C41E20-0x00C41E90
	public static bool IsIgnoreBaisokuMotion(Const.creature.Index index) => default; // 0x00C41E90-0x00C41F00
	public static float GetWalkSpeed(Const.creature.Index index, FormType formType) => default; // 0x00C41F00-0x00C41F80
	public static float GetRunRateGround(Const.creature.Index index, FormType formType) => default; // 0x00C41F80-0x00C42000
	public static List<Const.creature.Index> GetLockPokemonListByStatue() => default; // 0x00C42000-0x00C42220
	public static bool HasWazamachine(Const.creature.Index index, Const.item.Index wazaMachine) => default; // 0x00C42220-0x00C422A0
	public static Const.creature.Index GetKindIndex(Const.creature.Index index) => default; // 0x00C422A0-0x00C422D0
	public static bool IsCanEvo_RareColor(Const.creature.Index index) => default; // 0x00C422D0-0x00C42310
	public static List<Const.pokemon.Type> GetKyoutekiWeak(Const.creature.Index index) => default; // 0x00C42310-0x00C42490
	public static Const.ability.Index GetAbility(Const.creature.Index index, int abilityIndex) => default; // 0x00C42490-0x00C42510
	public static int GetOrganizationId(Const.creature.Index index) => default; // 0x00C42510-0x00C42580
}

