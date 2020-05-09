/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon.status;
using Const.pokemon;
using Const.waza;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class WazaDatabase // TypeDefIndex: 5765
{
	// Constructors
	public WazaDatabase() {} // 0x00744FC0-0x00744FD0

	// Methods
	public static int GetActIndex(Const.waza.Index wazaIndex) => default; // 0x00742E40-0x00742EB0
	public static int GetActIndex(Const.waza.Index wazaIndex, ICreature creature) => default; // 0x007441E0-0x007443D0
	public static int GetActIndex(Const.waza.Index wazaIndex, StatusBase status, Const.dungeon.status.Index weather, bool bSleep) => default; // 0x007443D0-0x00744490
	public static string GetWazaName(Const.waza.Index index, bool bGrade = true /* Metadata: 0x00611EE9 */, bool bColor = true /* Metadata: 0x00611EEA */) => default; // 0x00744490-0x007445B0
	public static string GetWazaPureName(Const.waza.Index index) => default; // 0x007445B0-0x007446C0
	public static bool CheckForbiddenRenketsu(Const.waza.Index index) => default; // 0x007446C0-0x00744730
	public static int GetGrade(Const.waza.Index index) => default; // 0x00744730-0x007447A0
	public static int GetExperience(Const.waza.Index index) => default; // 0x007447A0-0x00744810
	public static int GetPower(Const.waza.Index index, bool defaultValue) => default; // 0x00744810-0x00744890
	public static int GetHitRate(Const.waza.Index index, bool defaultValue) => default; // 0x00744890-0x00744910
	public static int GetPP(Const.waza.Index index, bool defaultValue) => default; // 0x00744910-0x00744990
	public static int AddPower(Const.waza.Index index, int value) => default; // 0x00744990-0x00744A10
	public static int AddHitRate(Const.waza.Index index, int value) => default; // 0x00744A10-0x00744A90
	public static int AddPP(Const.waza.Index index, int value) => default; // 0x00744A90-0x00744B10
	public static int GetPowerLimit(Const.waza.Index index) => default; // 0x00744B10-0x00744B80
	public static int GetHitRateLimit(Const.waza.Index index) => default; // 0x00744B80-0x00744BF0
	public static int GetPPLimit(Const.waza.Index index) => default; // 0x00744BF0-0x00744C60
	public static Const.pokemon.Type GetType(Const.waza.Index index, PokemonStatus status = null) => default; // 0x00744C60-0x00744E60
	public static Const.pokemon.Type GetType(Const.waza.Index index, Creature creature) => default; // 0x00744E60-0x00744FC0
}

