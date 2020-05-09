/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.camp;
using Const.common_reward;
using Const.creature;
using Const.fixed_reward;
using Const.item;
using Const.pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class RewardDatabase // TypeDefIndex: 5226
{
	// Nested types
	public struct CommonDataInfo // TypeDefIndex: 5227
	{
		// Fields
		public int rewardStandardTableNo; // 0x10
		public int addRewardTableNo1; // 0x14
		public int addRewardRate1; // 0x18
		public int addRewardTableNo2; // 0x1C
		public int addRewardRate2; // 0x20
		public int addRewardTableNo3; // 0x24
		public int addRewardRate3; // 0x28
		public int money; // 0x2C
		public int rankPoint; // 0x30
		public Const.creature.Index pokemonIndex; // 0x34
		public int pokemonLevel; // 0x38
	}

	public struct FixedDataInfo // TypeDefIndex: 5228
	{
		// Fields
		public Const.item.Index fixedRemunerationA; // 0x10
		public Const.item.Index fixedRemunerationB; // 0x14
		public Const.item.Index fixedRemunerationC; // 0x18
		public FixedWarehouseId fixedRemunerationFixedPokemon; // 0x1C
		public int fixedRemunerationUseCountA; // 0x20
		public int fixedRemunerationNumA; // 0x24
		public int fixedRemunerationUseCountB; // 0x28
		public int fixedRemunerationNumB; // 0x2C
		public int fixedRemunerationUseCountC; // 0x30
		public int fixedRemunerationNumC; // 0x34
		public int fixedRemunerationMoney; // 0x38
		public Const.camp.Index fixedRemunerationCampIndex; // 0x3C

		// Methods
		private bool IsValidCampIndex() => default; // 0x00837020-0x008372A0
		public void Dump() {} // 0x008372A0-0x008372B0
	}

	// Constructors
	public RewardDatabase() {} // 0x00837010-0x00837020

	// Methods
	public static CommonDataInfo GetCommonDataInfo(Const.common_reward.Index index) => default; // 0x00836640-0x00836850
	public static CommonDataInfo GetCommonDataInfoFromDifficulty(int difficulty) => default; // 0x00836850-0x00836860
	private static int _TargetFloorToBonusIndex(int floor) => default; // 0x00836860-0x008368F0
	public static int GetCommonDataItemNumMagFromDifficultyAndFloor(int difficulty, int floor) => default; // 0x008368F0-0x00836A20
	public static int GetCommonDataRankPointFromDifficultyAndFloor(int difficulty, int floor) => default; // 0x00836A20-0x00836BA0
	public static int GetCommonDataMoneyFromDifficultyAndFloor(int difficulty, int floor) => default; // 0x00836BA0-0x00836CD0
	public static FixedDataInfo GetFixedDataInfo(Const.fixed_reward.Index index) => default; // 0x00836CD0-0x00836F10
	public static Const.item.Index GetRandomItemIndex(CommonRewardType type, int tableNo, int rate) => default; // 0x00836F10-0x00836F90
	public static int GetRandomMoney(CommonRewardType type, int difficulty) => default; // 0x00836F90-0x00837010
}

