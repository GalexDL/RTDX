/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.dungeon;
using Const.item;
using Const.pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DungeonParameter // TypeDefIndex: 4628
{
	// Fields
	public List<KeyValuePair<PokemonWarehouseId, ExtraPokemonType>> ExtraPokemons; // 0x28
	public List<DungeonBossBattleState> DungeonBossBattleStates; // 0x30
	public OptionData Option; // 0x38
	public EventHandlerData EventHandler; // 0x40
	public DungeonResultParameter ResultParameter; // 0x48
	public Const.item.Index HonkiticketIndex; // 0x50

	// Properties
	public DungeonStartMode StartMode { get; set; } // 0x00BBD630-0x00BBD640 0x00BBD620-0x00BBD630
	public Const.dungeon.Index Index { get; set; } // 0x00BBD650-0x00BBD660 0x00BBD640-0x00BBD650
	public int Floor { get; set; } // 0x00BBD670-0x00BBD680 0x00BBD660-0x00BBD670
	public int RescueFloor { get; set; } // 0x00BBD690-0x00BBD6A0 0x00BBD680-0x00BBD690
	public uint Seed { get; set; } // 0x00BBD6B0-0x00BBD6C0 0x00BBD6A0-0x00BBD6B0

	// Nested types
	public class OptionData // TypeDefIndex: 4629
	{
		// Fields
		public ThunksPresentType FriendRescuePresentType; // 0x10
		public bool DungeonBannerOff; // 0x14
		public bool NextWhiteIn; // 0x15
		public bool Scenario; // 0x16
		public bool ScenarioDisableHelper; // 0x17
		public bool PerippaaIslandMode; // 0x18
		public bool HonkinoKunrenMode; // 0x19
		public bool HeroPartnerForceEvolution; // 0x1A
		public bool ClearResultProcessOff; // 0x1B
		public bool BounusDungeon; // 0x1C

		// Constructors
		public OptionData() {} // 0x00BBD7C0-0x00BBD7D0

		// Methods
		public void Clear() {} // 0x00BBDBB0-0x00BBDBC0
		public void ExportStream(DataExchangeByteMemoryStream byteStream) {} // 0x00BBE080-0x00BBE140
		public void ImportStream(DataExchangeByteMemoryStream byteStream) {} // 0x00BBE5B0-0x00BBE6A0
	}

	public class EventHandlerData // TypeDefIndex: 4630
	{
		// Fields
		public Handler2 OnCheckInitFloorForScriptEvent; // 0x10
		public Handler OnInitFloorForScriptEvent; // 0x18
		public Handler OnLoopCallback; // 0x20

		// Nested types
		public delegate IEnumerator Handler(); // TypeDefIndex: 4631; 0x00BBE8B0-0x00BBEC00

		public delegate void Handler2(); // TypeDefIndex: 4632; 0x00BBEC60-0x00BBEFD0

		// Constructors
		public EventHandlerData() {} // 0x00BBD7D0-0x00BBD7E0
	}

	// Constructors
	public DungeonParameter() {} // 0x00BBD6C0-0x00BBD7C0

	// Methods
	public void AddExtraFixedPokemon(FixedWarehouseId id, ExtraPokemonType type) {} // 0x00BBDA20-0x00BBDB10
	public void AddExtraPokemon(PokemonWarehouseId id, ExtraPokemonType type) {} // 0x00BBDB10-0x00BBDBB0
	public void Reset() {} // 0x00BBD900-0x00BBDA20
	public void ToNative() {} // 0x00BBDC50-0x00BBE080
	public void FromNative(bool bFromBackup) {} // 0x00BBE2F0-0x00BBE5B0
}

