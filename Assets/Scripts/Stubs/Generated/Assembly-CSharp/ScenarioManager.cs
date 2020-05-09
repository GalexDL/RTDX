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
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ScenarioManager : Singleton<ScenarioManager> // TypeDefIndex: 5229
{
	// Fields
	private BaseMapInfo baseMapInfo_; // 0x10
	private List<CampTypePair_> campTypePairTbl_; // 0x18
	private string[] flagFileName; // 0x20

	// Nested types
	[Serializable]
	public class SaveData // TypeDefIndex: 5230
	{
		// Fields
		[SerializeField] // 0x00618530-0x00618540
		private SerializableDictionary_String_Int forTopMenuProgressTbl; // 0x10

		// Nested types
		[Serializable]
		public class SerializableDictionary_String_Int : SerializableDictionary<string, int> // TypeDefIndex: 5231
		{
			// Constructors
			public SerializableDictionary_String_Int() {} // 0x00CB5CF0-0x00CB5D40
		}

		// Constructors
		public SaveData() {} // 0x00CB5C50-0x00CB5CF0

		// Methods
		public void Clear() {} // 0x00CB5680-0x00CB5700
		public void OnPreSave() {} // 0x00CB5700-0x00CB5970
		public void OnAfterLoad() {} // 0x00CB5970-0x00CB5C50
	}

	public enum ProgressForDebug // TypeDefIndex: 5232
	{
		AfterEnding = 0
	}

	public struct DungeonOpenConditionInfo // TypeDefIndex: 5233
	{
		// Fields
		public Const.dungeon.Index dgIndex; // 0x10
		public DungeonCondition dgCondition; // 0x14

		// Properties
		public bool IsScenarioDg { get => default; } // 0x00CB5660-0x00CB5680 
	}

	public class BaseMapInfo // TypeDefIndex: 5234
	{
		// Fields
		public CampMapLoader.CampType campType; // 0x10
		public CampMapLoader.CampLevel campLevel; // 0x14

		// Constructors
		public BaseMapInfo() {} // 0x00CB4090-0x00CB40A0
	}

	private class CampTypePair_ // TypeDefIndex: 5235
	{
		// Fields
		public CampMapLoader.CampType campType; // 0x10
		public Const.creature.Index pokemonIndex; // 0x14

		// Constructors
		public CampTypePair_() {} // 0x00CB54C0-0x00CB54D0
	}

	public enum TeamFlag_HeroIndex // TypeDefIndex: 5236
	{
		NONE = 0,
		PIKACHUU = 1,
		NYAASU = 2,
		IIBUI = 3,
		ENEKO = 4,
		ZENIGAME = 5,
		WANINOKO = 6,
		MIZUGOROU = 7,
		KODAKKU = 8,
		HITOKAGE = 9,
		ACHAMO = 10,
		HINOARASHI = 11,
		KARAKARA = 12,
		WANRIKII = 13,
		FUSHIGIDANE = 14,
		CHIKORIITA = 15,
		KIMORI = 16,
		MAX = 17
	}

	public enum TeamFlagIndex // TypeDefIndex: 5237
	{
		Flag_00 = 0,
		Flag_01 = 1,
		Flag_02 = 2,
		Flag_03 = 3,
		Flag_04 = 4,
		Flag_05 = 5,
		Flag_06 = 6,
		Flag_07 = 7,
		Flag_08 = 8,
		Flag_09 = 9,
		Flag_10 = 10,
		Flag_11 = 11,
		Flag_12 = 12,
		Flag_13 = 13,
		Flag_14 = 14,
		Flag_15 = 15,
		Flag_16 = 16,
		Flag_100 = 17,
		Flag_101 = 18,
		Flag_102 = 19,
		Flag_103 = 20,
		Flag_104 = 21,
		Flag_105 = 22,
		Flag_106 = 23,
		Flag_107 = 24,
		Flag_108 = 25,
		Flag_109 = 26,
		Flag_110 = 27,
		Flag_111 = 28,
		Flag_112 = 29,
		Flag_113 = 30,
		Flag_114 = 31,
		MAX = 32
	}

	public enum StatueLevel // TypeDefIndex: 5238
	{
		Off = 0,
		Level01 = 1,
		Level02 = 2,
		Level03 = 3,
		Level04 = 4
	}

	// Constructors
	public ScenarioManager() {} // 0x00CB4360-0x00CB54C0

	// Methods
	public void Init() {} // 0x00CB3020-0x00CB30A0
	private void UpdateProgress_() {} // 0x00CB30A0-0x00CB30D0
	public void SetProgressNumber(ScenarioProgressType type, int progressNo) {} // 0x00CB35F0-0x00CB3680
	public int GetProgress_ForDebug(ScenarioProgressType type) => default; // 0x00CB3680-0x00CB36F0
	public void SetProgress_ForDebug(ProgressForDebug progressForDebug) {} // 0x00CB36F0-0x00CB3780
	public bool CheckConditionFlag(string conditionLabel) => default; // 0x00CB3780-0x00CB37F0
	public List<string> EnumProgressConditionLabel_ForDebug() => default; // 0x00CB37F0-0x00CB3960
	public List<DungeonOpenConditionInfo> EnumCurrentDungeonOpenCondition() => default; // 0x00CB3960-0x00CB3EE0
	public DungeonCondition GetCurrentDungeonOpenCondition(Const.dungeon.Index dgIndex) => default; // 0x00CB3EF0-0x00CB3FB0
	public bool IsOldDLCDungeonOpened() => default; // 0x00CB3FC0-0x00CB4090
	private void UpdateBaseMapInfo_() {} // 0x00CB30D0-0x00CB34E0
	public BaseMapInfo GetBaseMapInfoData() => default; // 0x00CB40B0-0x00CB40C0
	public string GetTeamFlagFileName(TeamFlagIndex flagIndex) => default; // 0x00CB40C0-0x00CB4110
	public TeamFlagIndex GetHeroTeamFlagIndex() => default; // 0x00CB4110-0x00CB4120
	public TeamFlag_HeroIndex GetTeamFlag_HeroIndex() => default; // 0x00CB4120-0x00CB42E0
	public void UpdateTeamFlag_() {} // 0x00CB34E0-0x00CB35F0
	public StatueLevel GetStatueLevel() => default; // 0x00CB42E0-0x00CB4360
}

