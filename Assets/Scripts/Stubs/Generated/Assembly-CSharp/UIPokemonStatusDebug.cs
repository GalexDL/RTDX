/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIPokemonStatusDebug : UIManagerBase // TypeDefIndex: 7433
{
	// Fields
	private MenuType menuType_; // 0x1C
	private PokemonWarehouseListWindow_Debug pokemonWarehouseListWindow_; // 0x20
	public FiniteStateMachine<UIPokemonStatusDebug, States> FSM; // 0x28

	// Nested types
	public enum MenuType // TypeDefIndex: 7434
	{
		LEVEL = 0,
		SUGOWAZA = 1
	}

	private class PokemonWarehouseListWindow_Debug : PokemonWarehouseListWindow // TypeDefIndex: 7435
	{
		// Fields
		private UIPokemonStatusDebug manager_; // 0xC8
		private GameObject obj_; // 0xD0
		private bool bInit; // 0xD8

		// Properties
		public bool bInit_ { get => default; set {} } // 0x00B4DF30-0x00B4DF40 0x00B4DF40-0x00B4DF50

		// Constructors
		public PokemonWarehouseListWindow_Debug() {} // 0x00B4D620-0x00B4D630

		// Methods
		public void SetData(UIPokemonStatusDebug manager) {} // 0x00B4DD10-0x00B4DD40
		protected override bool _doDecide() => default; // 0x00B4DD40-0x00B4DDE0
		protected override bool _doCancel() => default; // 0x00B4DDE0-0x00B4DE40
		protected override bool _onYButton() => default; // 0x00B4DE40-0x00B4DEF0
		protected override void ListUpdate() {} // 0x00B4DEF0-0x00B4DF30
	}

	public enum States // TypeDefIndex: 7436
	{
		PokemonSelect = 0,
		LevelSelect = 1,
		SugowazaSelect = 2,
		End = 3
	}

	public class StatePokemonSelect : FSMState<UIPokemonStatusDebug, States> // TypeDefIndex: 7437
	{
		// Properties
		public override States StateID { get => default; } // 0x00B4E490-0x00B4E4A0 

		// Constructors
		public StatePokemonSelect() {} // 0x00B4D630-0x00B4D680

		// Methods
		public override void Enter() {} // 0x00B4E4A0-0x00B4E600
		public override void Execute() {} // 0x00B4E600-0x00B4E620
		public override void Exit() {} // 0x00B4E620-0x00B4E630
	}

	public class StateLevelSelect : FSMState<UIPokemonStatusDebug, States> // TypeDefIndex: 7438
	{
		// Fields
		private UIMoneyDebug moneyDebug_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00B4DF90-0x00B4DFA0 

		// Constructors
		public StateLevelSelect() {} // 0x00B4D680-0x00B4D6D0

		// Methods
		// [IteratorStateMachine] // 0x0064F4A0-0x0064F510
		private IEnumerator Loop() => default; // 0x00B4DFA0-0x00B4E010
		private void SetLevel(int level) {} // 0x00B4E040-0x00B4E110
		public override void Enter() {} // 0x00B4E110-0x00B4E2A0
		public override void Execute() {} // 0x00B4E2A0-0x00B4E2B0
		public override void Exit() {} // 0x00B4E2B0-0x00B4E2C0
	}

	public class StateSugowazaSelect : FSMState<UIPokemonStatusDebug, States> // TypeDefIndex: 7440
	{
		// Properties
		public override States StateID { get => default; } // 0x00B4E650-0x00B4E660 

		// Constructors
		public StateSugowazaSelect() {} // 0x00B4D6D0-0x00B4D720

		// Methods
		public override void Enter() {} // 0x00B4E660-0x00B4E730
		public override void Execute() {} // 0x00B4E7A0-0x00B4E7B0
		public override void Exit() {} // 0x00B4E7B0-0x00B4E7C0
		// [IteratorStateMachine] // 0x0064F520-0x0064F590
		private IEnumerator SugowazaLoop() => default; // 0x00B4E730-0x00B4E7A0
		private void SetSugowaza(int index) {} // 0x00B4E7F0-0x00B4E950
	}

	public class StateEnd : FSMState<UIPokemonStatusDebug, States> // TypeDefIndex: 7443
	{
		// Properties
		public override States StateID { get => default; } // 0x00B4DF50-0x00B4DF60 

		// Constructors
		public StateEnd() {} // 0x00B4D720-0x00B4D770

		// Methods
		public override void Enter() {} // 0x00B4DF60-0x00B4DF70
		public override void Execute() {} // 0x00B4DF70-0x00B4DF80
		public override void Exit() {} // 0x00B4DF80-0x00B4DF90
	}

	// Constructors
	public UIPokemonStatusDebug() {} // 0x00B4D910-0x00B4D920

	// Methods
	public static UIPokemonStatusDebug Create(MenuType menuType) => default; // 0x00B4D2E0-0x00B4D410
	public void Construct() {} // 0x00B4D410-0x00B4D620
	// [IteratorStateMachine] // 0x0062C050-0x0062C0C0
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00B4D770-0x00B4D7E0
	// [IteratorStateMachine] // 0x0062C0C0-0x0062C130
	public override IEnumerator MainFlow() => default; // 0x00B4D810-0x00B4D880
	private void Update() {} // 0x00B4D8B0-0x00B4D910
}

