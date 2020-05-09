/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.camp;
using Const.creature;
using Const.dungeon;
using Const.item;
using Const.pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ShopFlowTagSetManager // TypeDefIndex: 5471
{
	// Fields
	public const string s_pb = "PB"; // Metadata: 0x00611975
	public const string s_ib = "IB"; // Metadata: 0x0061197B
	public const string s_money = "st_money"; // Metadata: 0x00611981
	public const string s_value = "st_value"; // Metadata: 0x0061198D
	public const string s_waza = "st_waza"; // Metadata: 0x00611999
	public const string s_kind = "st_kind"; // Metadata: 0x006119A4
	public const string s_camp = "st_camp"; // Metadata: 0x006119AF
	public const string s_tutorial = "st_tutorial_name"; // Metadata: 0x006119BA
	public const string s_dungeon = "st_dungeon"; // Metadata: 0x006119CE
	public const string s_team = "st_team"; // Metadata: 0x006119DC
	public const string s_type = "st_type"; // Metadata: 0x006119E7
	private List<TagDataBase> tagDataList; // 0x10

	// Nested types
	public class TagDataBase // TypeDefIndex: 5472
	{
		// Fields
		public string tagType; // 0x10
		public int bufNum; // 0x18

		// Constructors
		public TagDataBase() {} // 0x009DB7F0-0x009DB800
	}

	public class TagSetString : TagDataBase // TypeDefIndex: 5473
	{
		// Fields
		public string strValue; // 0x20
		public string strValuePlural; // 0x28
		public int strBaseIndex; // 0x30

		// Constructors
		public TagSetString() {} // 0x009DB1A0-0x009DB200
	}

	public class TagSetNum : TagDataBase // TypeDefIndex: 5474
	{
		// Fields
		public int iValue; // 0x1C

		// Constructors
		public TagSetNum() {} // 0x009DB390-0x009DB3A0
	}

	public class TagSetPokemon : TagDataBase // TypeDefIndex: 5475
	{
		// Fields
		public Const.creature.Index pokemonIndex; // 0x1C

		// Constructors
		public TagSetPokemon() {} // 0x009DB440-0x009DB450
	}

	public class TagSetPokemonString : TagDataBase // TypeDefIndex: 5476
	{
		// Fields
		public string pokemonName; // 0x20

		// Constructors
		public TagSetPokemonString() {} // 0x009DB800-0x009DB810
	}

	public class TagSetCamp : TagDataBase // TypeDefIndex: 5477
	{
		// Fields
		public Const.camp.Index campIndex; // 0x1C

		// Constructors
		public TagSetCamp() {} // 0x009DB4F0-0x009DB500
	}

	public class TagSetKind : TagDataBase // TypeDefIndex: 5478
	{
		// Fields
		public Const.creature.Index kindIndex; // 0x1C

		// Constructors
		public TagSetKind() {} // 0x009DB5A0-0x009DB5B0
	}

	public class TagSetItem : TagDataBase // TypeDefIndex: 5479
	{
		// Fields
		public Const.item.Index itemIndex; // 0x1C

		// Constructors
		public TagSetItem() {} // 0x009DB650-0x009DB660
	}

	public class TagSetDungeon : TagDataBase // TypeDefIndex: 5480
	{
		// Fields
		public Const.dungeon.Index dungeonIndex; // 0x1C

		// Constructors
		public TagSetDungeon() {} // 0x009DB700-0x009DB710
	}

	public class TagSetType : TagDataBase // TypeDefIndex: 5481
	{
		// Fields
		public string typeString; // 0x20

		// Constructors
		public TagSetType() {} // 0x009DB7E0-0x009DB7F0
	}

	// Constructors
	private ShopFlowTagSetManager() {} // 0x009DAFB0-0x009DAFC0

	// Methods
	public static ShopFlowTagSetManager Create() => default; // 0x009DAFC0-0x009DB050
	public void ResetTagDataList() {} // 0x009DB050-0x009DB0C0
	public List<TagDataBase> GetTagDataList() => default; // 0x009DB0C0-0x009DB0D0
	public void SetTagDataList(string type, int buf, string value) {} // 0x009DB0D0-0x009DB1A0
	public void SetTagDataList_Item(string type, int buf, string value, string valuePlural, Const.item.Index valueBaseIndex) {} // 0x009DB200-0x009DB2F0
	public void SetTagDataList(string type, int buf, int value) {} // 0x009DB2F0-0x009DB390
	public void SetTagDataList(string type, int buf, Const.creature.Index value) {} // 0x009DB3A0-0x009DB440
	public void SetTagDataList(string type, int buf, Const.camp.Index value) {} // 0x009DB450-0x009DB4F0
	public void SetTagDataList_Kind(string type, int buf, Const.creature.Index value) {} // 0x009DB500-0x009DB5A0
	public void SetTagDataList(string type, int buf, Const.item.Index value) {} // 0x009DB5B0-0x009DB650
	public void SetTagDataList(string type, int buf, Const.dungeon.Index value) {} // 0x009DB660-0x009DB700
	public void SetTagDataList(string type, int buf, Const.pokemon.Type value) {} // 0x009DB710-0x009DB7E0
}

