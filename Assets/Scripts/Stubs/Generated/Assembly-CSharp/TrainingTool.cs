/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon;
using Const.item;
using Const.pokemon;
using Const.tutorial;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class TrainingTool // TypeDefIndex: 6417
{
	// Nested types
	[Serializable]
	public class SaveData // TypeDefIndex: 6418
	{
		// Fields
		[SerializeField] // 0x006186E0-0x006186F0
		public bool[] clearFlags; // 0x10

		// Constructors
		public SaveData() {} // 0x007DF0D0-0x007DF140

		// Methods
		public void OnPreSave() {} // 0x007DF140-0x007DF500
		public void OnAfterLoad() {} // 0x007DF500-0x007DF8E0
		public void Reset() {} // 0x007DF8E0-0x007DFD00
	}

	// Constructors
	public TrainingTool() {} // 0x007DF0C0-0x007DF0D0

	// Methods
	public static string GetTutorialName(Const.tutorial.Index index) => default; // 0x007DE6D0-0x007DE7B0
	public static string GetTutorialExplanation(Const.tutorial.Index index) => default; // 0x007DE7B0-0x007DE890
	public static int Tutorial_GetSuccessCount(Const.tutorial.Index index) => default; // 0x007DE890-0x007DE900
	public static Const.item.Index Tutorial_GetFirstCompensation(Const.tutorial.Index index) => default; // 0x007DE900-0x007DEA80
	public static int Tutorial_GetFirstItemCount(Const.tutorial.Index index) => default; // 0x007DEA80-0x007DEAF0
	public static int Tutorial_GetSecondCompensationTable(Const.tutorial.Index index) => default; // 0x007DEAF0-0x007DEB60
	public static int Tutorial_GetSecondItemCountLottery(Const.tutorial.Index index) => default; // 0x007DEB60-0x007DEBD0
	public static int Tutorial_GetSortKey(Const.tutorial.Index index) => default; // 0x007DEBD0-0x007DEC40
	public static bool Tutorial_GetClearFlag(Const.tutorial.Index index) => default; // 0x007DEC40-0x007DECB0
	public static void Tutorial_SetClearFlag(Const.tutorial.Index index, bool b) {} // 0x007DECB0-0x007DED30
	public static bool CheckTutorialAllClear() => default; // 0x007DED30-0x007DEF70
	public static int Training_GetFloorNum(Const.tutorial.Index index) => default; // 0x007DEF70-0x007DEFE0
	public static Const.dungeon.Index Training_GetDungeonIndex(Const.tutorial.Index index) => default; // 0x007DEFE0-0x007DF050
	public static Const.dungeon.Index GetTrainingDungeonIndex(Const.pokemon.Type type) => default; // 0x007DF050-0x007DF0C0
}

