/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.creature;
using Const.pokemon;
using Const.status;
using Const.waza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Creature : ICreature // TypeDefIndex: 4622
{
	// Fields
	private ulong m_nativePointerId; // 0x10

	// Properties
	public ulong NativePointerId { get => default; } // 0x00983FA0-0x00983FB0 

	// Constructors
	public Creature() {} // Dummy constructor
	public Creature(ulong nativePointerId) {} // 0x00984040-0x00984070

	// Methods
	public static ICreature GetPlayer() => default; // 0x00983FB0-0x00984040
	public static List<ICreature> GetPartyList() => default; // 0x00984070-0x009841F0
	public static List<ICreature> GetMonsterList() => default; // 0x009843C0-0x00984550
	public static List<ICreature> GetList() => default; // 0x009841F0-0x009843C0
	public static ICreature FindCreature(ICreature observer, DungeonCoord coord, DungeonDirection direction, int distance, bool narrowOnly) => default; // 0x00984A80-0x00984CB0
	public static List<ICreature> FindCreatures(ICreature observer, DungeonCoord coord, DungeonDirection direction, int distance, bool narrowOnly) => default; // 0x00984CB0-0x00984F20
	public static ICreature GetCreature(DungeonCoord coord) => default; // 0x00984F20-0x00984FE0
	public static ICreature GetCreature(IStatusBase status) => default; // 0x00984FE0-0x009850F0
	public DungeonCoord GetCoord() => default; // 0x009850F0-0x00985200
	public DungeonDirection GetDirection() => default; // 0x00985200-0x009852A0
	public List<ICreature> FindEnemies(int distance, bool narrowOnly, bool ignoreLook, DungeonCoord overwriteCoord, DungeonDirection overwriteDir) => default; // 0x009852A0-0x009855E0
	public string GetName() => default; // 0x009855E0-0x00985700
	public bool IsPlayer() => default; // 0x00985700-0x00985770
	public bool IsParty() => default; // 0x00985770-0x009857E0
	public bool IsGuest() => default; // 0x009857E0-0x00985850
	public bool IsGuestParty() => default; // 0x00985850-0x009858C0
	public bool IsQuestGuest() => default; // 0x009858C0-0x00985930
	public bool IsMonster() => default; // 0x00985930-0x009859A0
	public bool IsAlive() => default; // 0x009859A0-0x00985A10
	public bool IsPinch() => default; // 0x00985A10-0x00985A80
	public bool IsBigBody() => default; // 0x00985A80-0x00985AF0
	public IPokemonStatus GetStatus() => default; // 0x00985AF0-0x00985BD0
	public Const.creature.Index GetIndex() => default; // 0x00985BD0-0x00985C40
	public Const.creature.Index GetAppearanceIndex() => default; // 0x00985C40-0x00985CB0
	public bool AddItem(IItem item) => default; // 0x00985CB0-0x00985D50
	public bool RemoveItem(IItem item) => default; // 0x00985D50-0x00985DF0
	public int GetMoraibiStage() => default; // 0x00985DF0-0x00985E60
	public bool HasBadStatus(Const.status.Index statusIndex) => default; // 0x00985E60-0x00985EE0
	public bool HasNoUseItemBadStatus() => default; // 0x00985EE0-0x00985F50
	public bool HasNoTargetItemBadStatus() => default; // 0x00985F50-0x00985FC0
	public bool HasNoUseWazaBadStatus() => default; // 0x00985FC0-0x00986030
	public bool HasNoUseStairsBadStatus() => default; // 0x00986030-0x009860A0
	public bool HasNoUseMenuBadStatus() => default; // 0x009860A0-0x00986110
	public IItem SetEquippedItem(IItem item) => default; // 0x00986110-0x009861E0
	public void CheckWazaAffinity(Creature target, Affinity[] affinity) {} // 0x009861E0-0x009863F0
	public Const.pokemon.Type GetType(int typeIndex) => default; // 0x009863F0-0x00986470
	public Const.waza.Index GetWaza(int index, bool original) => default; // 0x00986470-0x00986500
	public int GetWazaCount(bool original) => default; // 0x00986500-0x00986580
	public int GetWazaPP(int index, bool original) => default; // 0x00986580-0x00986610
	public int GetWazaPPMax(Const.waza.Index wazaIndex) => default; // 0x00986610-0x00986690
	public string GetWazaName(Const.waza.Index wazaIndex, bool original, bool grade, bool color) => default; // 0x00986690-0x009867D0
	public bool IsEnableWaza(int index, bool original) => default; // 0x009867D0-0x00986860
	public void SetEnableWaza(int index, bool set) {} // 0x00986860-0x009868F0
	public bool IsTemporaryWaza(int index) => default; // 0x009868F0-0x00986970
	public bool IsLearnedWaza(Const.waza.Index wazaIndex, bool original) => default; // 0x00986970-0x00986A00
	public bool IsPossibleUseWaza(int index) => default; // 0x00986A00-0x00986A80
	public void ClearTemporaryWaza(int index) {} // 0x00986A80-0x00986B00
	public void SwapWaza(int indexA, int indexB) {} // 0x00986B00-0x00986B90
	public List<int> GetRenketsuList(int wazaStatusId) => default; // 0x00986B90-0x00986D30
	public bool IsWazaRenketsuParent(int index) => default; // 0x00986F80-0x00987000
	public bool IsWazaRenketsuChild(int index) => default; // 0x00987000-0x00987080
	public int GetWazaRenketsuParentValue(int index) => default; // 0x00987080-0x00987100
	public int GetWazaRenketsuChildValue(int index) => default; // 0x00987100-0x00987180
	public void UpdateSupportNpcUsed() {} // 0x00987180-0x00987270
	public int GetCharacterModelNativeControlId() => default; // 0x00987270-0x009872E0
	public Vector3 GetCharacterFloorPosition() => default; // 0x009872E0-0x00987440
	public Vector3 GetCharacterFloorScreenPosition() => default; // 0x00987440-0x00987480
	public bool IsSpotPosition() => default; // 0x00987480-0x009874F0
}

