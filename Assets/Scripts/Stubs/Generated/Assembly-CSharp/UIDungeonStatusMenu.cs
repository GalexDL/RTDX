/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIDungeonStatusMenu // TypeDefIndex: 6855
{
	// Fields
	private UIDungeonStatusMenuTop menu_; // 0x10
	private bool bExit_; // 0x18
	protected bool bSingleCall; // 0x19
	public FiniteStateMachine<UIDungeonStatusMenu, States> FSM; // 0x20

	// Properties
	public UIDungeonStatusMenuTop MENU { get => default; set {} } // 0x00D65D90-0x00D65DA0 0x00D65DA0-0x00D65DB0
	public bool EXIT { get => default; set {} } // 0x00D65DB0-0x00D65DC0 0x00D65DC0-0x00D65DD0

	// Nested types
	public enum States // TypeDefIndex: 6856
	{
		Init = 0,
		Start = 1,
		ReStart = 2,
		Status = 3,
		End = 4
	}

	public class StateInit : FSMState<UIDungeonStatusMenu, States> // TypeDefIndex: 6857
	{
		// Properties
		public override States StateID { get => default; } // 0x00D66540-0x00D66550 

		// Constructors
		public StateInit() {} // 0x00D66240-0x00D66290

		// Methods
		public override void Enter() {} // 0x00D66550-0x00D665C0
		public override void Execute() {} // 0x00D666E0-0x00D66760
		public override void Exit() {} // 0x00D66DD0-0x00D66DE0
	}

	public class StateStart : FSMState<UIDungeonStatusMenu, States> // TypeDefIndex: 6858
	{
		// Fields
		private UIDungeonStatusMenuTop.ActionType act_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00D66EE0-0x00D66EF0 

		// Constructors
		public StateStart() {} // 0x00D66290-0x00D662E0

		// Methods
		public override void Enter() {} // 0x00D66EF0-0x00D66FE0
		public override void Execute() {} // 0x00D66FE0-0x00D67070
		public override void Exit() {} // 0x00D67070-0x00D67080
	}

	public class StateReStart : FSMState<UIDungeonStatusMenu, States> // TypeDefIndex: 6859
	{
		// Properties
		public override States StateID { get => default; } // 0x00D66DE0-0x00D66DF0 

		// Constructors
		public StateReStart() {} // 0x00D662E0-0x00D66330

		// Methods
		public override void Enter() {} // 0x00D66DF0-0x00D66E00
		public override void Execute() {} // 0x00D66E00-0x00D66ED0
		public override void Exit() {} // 0x00D66ED0-0x00D66EE0
	}

	public class StateEnd : FSMState<UIDungeonStatusMenu, States> // TypeDefIndex: 6860
	{
		// Properties
		public override States StateID { get => default; } // 0x00D66500-0x00D66510 

		// Constructors
		public StateEnd() {} // 0x00D66380-0x00D663D0

		// Methods
		public override void Enter() {} // 0x00D66510-0x00D66520
		public override void Execute() {} // 0x00D66520-0x00D66530
		public override void Exit() {} // 0x00D66530-0x00D66540
	}

	public class StateStatus : FSMState<UIDungeonStatusMenu, States> // TypeDefIndex: 6861
	{
		// Fields
		private UIDungeonStatusInfo menu_; // 0x18
		private bool bExit_; // 0x20

		// Properties
		public override States StateID { get => default; } // 0x00D67090-0x00D670A0 

		// Constructors
		public StateStatus() {} // 0x00D66330-0x00D66380

		// Methods
		public override void Enter() {} // 0x00D670A0-0x00D671E0
		public override void Execute() {} // 0x00D67210-0x00D67280
		public override void Exit() {} // 0x00D67280-0x00D672B0
	}

	// Constructors
	public UIDungeonStatusMenu() {} // 0x00D65E90-0x00D65EA0

	// Methods
	public void SetSingleCall() {} // 0x00D65DD0-0x00D65DE0
	// [IteratorStateMachine] // 0x00628700-0x00628770
	public IEnumerator MainFlow(Action cb = null) => default; // 0x00D65DE0-0x00D65E60
}

