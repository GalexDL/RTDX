/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.camp;
using Const.creature;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class CampTool // TypeDefIndex: 6149
{
	// Nested types
	public class CampSorting // TypeDefIndex: 6150
	{
		// Fields
		private static CampSorting campSorting; // 0x00
		private CampData[] campArray; // 0x10

		// Properties
		public static CampSorting Instance { get => default; } // 0x008C6460-0x008C64B0 

		// Constructors
		private CampSorting() {} // 0x008D32E0-0x008D32F0

		// Methods
		public static void Create() {} // 0x008D32F0-0x008D3370
		public static void Delete() {} // 0x008D3370-0x008D33C0
		public void Init(List<IPokemonWarehouseStatus> nowList = null) {} // 0x008D33C0-0x008D3870
		public CampData GetCampInPokemonStatusList(Const.camp.Index campIndex) => default; // 0x008C64B0-0x008C6650
		public int GetCampInNotVisibleFixedCount(Const.camp.Index campIndex) => default; // 0x008D2B50-0x008D2C60
	}

	public class CampData // TypeDefIndex: 6151
	{
		// Fields
		public List<IPokemonWarehouseStatus> pokemonList; // 0x10

		// Constructors
		public CampData() {} // 0x008D3270-0x008D32E0
	}

	// Constructors
	public CampTool() {} // 0x008D2C60-0x008D2C70

	// Methods
	// [IteratorStateMachine] // 0x00624820-0x00624890
	public static IEnumerable<Const.camp.Index> EnumCampIndex() => default; // 0x008D0FD0-0x008D1040
	public static Const.camp.Index GetCampIndex(Const.creature.Index pokemonIndex) => default; // 0x008D1080-0x008D1170
	public static Const.creature.Index[] GetPokemonList(Const.camp.Index campIndex) => default; // 0x008D1170-0x008D1370
	public static bool GetCampShopDisplayFlag(Const.camp.Index campIndex) => default; // 0x008D1370-0x008D13E0
	public static bool GetCampShopSellFlag(Const.camp.Index campIndex) => default; // 0x008D13E0-0x008D1450
	public static bool GetCampShopGetWithPokemonFlag(Const.camp.Index campIndex) => default; // 0x008D1450-0x008D14C0
	public static int GetCampPrice(Const.camp.Index campIndex, float discount) => default; // 0x008D14C0-0x008D1550
	public static int GetCampWarehouseIncreaseNum(Const.camp.Index campIndex) => default; // 0x008D1550-0x008D15C0
	public static int GetCampSortNumPrice(Const.camp.Index campIndex) => default; // 0x008D15C0-0x008D1630
	public static bool GetCampBuyFlag(Const.camp.Index campIndex) => default; // 0x008D1630-0x008D16A0
	public static bool GetCampBuyFlag(int index) => default; // 0x008D16A0-0x008D1710
	public static void SetCampBuyFlag(Const.camp.Index campIndex, bool b) {} // 0x008D1710-0x008D1790
	public static bool GetCampNewFlag(Const.camp.Index campIndex) => default; // 0x008D1790-0x008D1800
	public static void SetCampNewFlag(Const.camp.Index campIndex, bool b) {} // 0x008D1800-0x008D1880
	public static bool GetCampNewAdditionFlag() => default; // 0x008D1880-0x008D1960
	public static string GetCampName(Const.camp.Index campIndex) => default; // 0x008D1A70-0x008D1B10
	public static string GetCampExplanation(Const.camp.Index campIndex) => default; // 0x008D1B10-0x008D1BF0
	public static bool isAllCampConstructed() => default; // 0x008D1BF0-0x008D1EE0
	public static bool GetShopProgress(Const.camp.Index campIndex) => default; // 0x008D1960-0x008D1A70
	public static bool GetEventProgress(Const.camp.Index campIndex) => default; // 0x008D1EE0-0x008D1FC0
	public static string GetFileName(Const.camp.Index campIndex) => default; // 0x008D1FC0-0x008D2060
	public static string GetBgmName(Const.camp.Index campIndex) => default; // 0x008D2060-0x008D2100
	public static List<IPokemonWarehouseStatus> GetCampMember(List<IPokemonWarehouseStatus> nowList = null) => default; // 0x008D2100-0x008D2300
	public static GummyAndSweetsUpStatus GetGummyUpStatus(IPokemonStatus status) => default; // 0x008D2300-0x008D23B0
	public static bool IsMax(IPokemonStatus status, GummyAndSweetsUpStatus upStatus) => default; // 0x008D2500-0x008D2620
	private static bool IsAllMax(IPokemonStatus status) => default; // 0x008D23B0-0x008D2430
	public static bool IsBigUp() => default; // 0x008D2620-0x008D2650
	private static int GetRandomIndex(params /* 0x0065AC70-0x0065AC80 */ int[] weightTable) => default; // 0x008D2430-0x008D2500
	public static Const.dungeon.Index GetOpenDungeonIndex(Const.camp.Index campIndex) => default; // 0x008D2650-0x008D26C0
	public static HashSet<Const.dungeon.Index> GetOpenDungeonIndexList() => default; // 0x008D26C0-0x008D2840
	public static bool IsCampEntryNumFromKyuujotaiRank(Const.camp.Index index) => default; // 0x008D2840-0x008D28B0
	public static int GetAllGummyCount() => default; // 0x008D28B0-0x008D2A00
	public static int GetAllDXGummyCount() => default; // 0x008D2A00-0x008D2B50
	public static int GetPokemonCount_VisibleFilter(Const.camp.Index index) => default; // 0x008CB1E0-0x008CB2F0
}

