/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public static class PegasusActDatabase // TypeDefIndex: 4397
{
	// Fields
	private static List<ActorData> actorDataList_; // 0x00

	// Nested types
	public class ActorData // TypeDefIndex: 4398
	{
		// Fields
		public string symbolName; // 0x10
		public Index raw_pokemonIndex; // 0x18
		public FormType raw_formType; // 0x1C
		public bool bIsFemale; // 0x20
		public PartyID opt_partyId; // 0x24
		public PokemonWarehouseId opt_warehouseId; // 0x28
		public TextId opt_specialName; // 0x30
		public string debug_name; // 0x38

		// Properties
		public string Name { get => default; } // 0x00B69180-0x00B69310 
		public Index PokemonIndex { get => default; } // 0x00B69530-0x00B697B0 
		public FormType FormType { get => default; } // 0x00B697B0-0x00B69B40 
		public PokemonWarehouseId WarehouseId { get => default; } // 0x00B69310-0x00B69530 

		// Nested types
		public enum PartyID // TypeDefIndex: 4399
		{
			NONE = 0,
			PARTY1 = 1,
			PARTY2 = 2,
			PARTY3 = 3
		}

		// Constructors
		public ActorData() {} // 0x00B69010-0x00B690B0
	}

	public class MapData // TypeDefIndex: 4400
	{
		// Fields
		public string symbolName; // 0x10
		public string assetBundleName; // 0x18
		public string prefabName; // 0x20

		// Constructors
		public MapData() {} // 0x00B60E20-0x00B60E30
	}

	public class GimmickData // TypeDefIndex: 4401
	{
		// Fields
		public string symbolName; // 0x10
		public string assetBundleName; // 0x18
		public string prefabName; // 0x20

		// Constructors
		public GimmickData() {} // 0x00B60F90-0x00B60FA0
	}

	public class EffectData // TypeDefIndex: 4402
	{
		// Fields
		public string symbolName; // 0x10
		public string effectSymbol; // 0x18

		// Constructors
		public EffectData() {} // 0x00B610D0-0x00B610E0
	}

	// Constructors
	static PegasusActDatabase() {} // 0x00B610E0-0x00B69010

	// Methods
	public static ActorData FindActorData(string symbol) => default; // 0x00B60B90-0x00B60C70
	public static void LoadCharaObject(Index index, FormType formType, Action<CharacterModel> loadedCb) {} // 0x00B60C80-0x00B60D90
	public static MapData FindMapData(string symbol) => default; // 0x00B60DA0-0x00B60E20
	public static GimmickData FindGimmick(string symbol) => default; // 0x00B60E30-0x00B60F90
	public static EffectData FindEffect(string symbol) => default; // 0x00B60FA0-0x00B610D0
}

