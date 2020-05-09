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
using Const.dungeon.status;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DungeonDatabase // TypeDefIndex: 4625
{
	// Constructors
	public DungeonDatabase() {} // 0x007B9670-0x007B9680

	// Methods
	public static string GetName(Const.dungeon.Index dungeonIndex, DungeonNameType nameType = DungeonNameType.FULL_KANJI /* Metadata: 0x00610A88 */) => default; // 0x007B8700-0x007B8820
	public static string GetStatusName(Const.dungeon.status.Index dungeonStatusIndex) => default; // 0x007B8820-0x007B8930
	public static string GetStatusExplanation(Const.dungeon.status.Index dungeonStatusIndex) => default; // 0x007B8930-0x007B8A40
	public static int GetMaxFloor(Const.dungeon.Index dungeonIndex) => default; // 0x007B8A40-0x007B8AB0
	public static int GetSortKey(Const.dungeon.Index dungeonIndex) => default; // 0x007B8AB0-0x007B8B20
	public static int GetRescueCount(Const.dungeon.Index dungeonIndex) => default; // 0x007B8B20-0x007B8B90
	public static bool IsAscend(Const.dungeon.Index dungeonIndex) => default; // 0x007B8B90-0x007B8C00
	public static bool IsJoining(Const.dungeon.Index dungeonIndex) => default; // 0x007B8C00-0x007B8C70
	public static bool IsOpenNotice(Const.dungeon.Index dungeonIndex) => default; // 0x007B8C70-0x007B8CE0
	public static bool IsTestDungeon(Const.dungeon.Index dungeonIndex) => default; // 0x007B8CE0-0x007B8CF0
	public static bool IsBossFloor(Const.dungeon.Index dungeonIndex, int floor) => default; // 0x007B8CF0-0x007B8D70
	public static bool IsSenrigan(Const.dungeon.Index dungeonIndex) => default; // 0x007B8D70-0x007B8DE0
	public static void LoadPokemonAppearList() {} // 0x007B8DE0-0x007B8E50
	public static void DestroyPokemonAppearList() {} // 0x007B8E50-0x007B8EC0
	public static List<Const.creature.Index> GetAppearPokemonListFromDungeon(Const.dungeon.Index index) => default; // 0x007B8EC0-0x007B9070
	public static List<Const.dungeon.Index> GetAppearPokemonDungeonListFromPokemon(Const.creature.Index index) => default; // 0x007B9070-0x007B9280
	public static List<Const.creature.Index> GetAppearPokemonListFromInvitation() => default; // 0x007B9280-0x007B93E0
	public static List<Const.creature.Index> GetAppearPokemonListFromOutbreak() => default; // 0x007B93E0-0x007B9540
	public static List<string> GetObstacleSymbolList() => default; // 0x007B9540-0x007B9670
}

