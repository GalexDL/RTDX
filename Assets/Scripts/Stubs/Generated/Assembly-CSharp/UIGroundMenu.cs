/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIGroundMenu // TypeDefIndex: 7074
{
	// Fields
	private UIMainMenu menu_; // 0x10
	private bool bExit_; // 0x18
	public Result RESULT; // 0x1C
	public FiniteStateMachine<UIGroundMenu, States> FSM; // 0x20

	// Properties
	public UIMainMenu MENU { get => default; set {} } // 0x00A81340-0x00A81350 0x00A81350-0x00A81360
	public bool EXIT { get => default; set {} } // 0x00A81360-0x00A81370 0x00A81370-0x00A81380

	// Nested types
	public enum Result // TypeDefIndex: 7075
	{
		None = 0,
		GotoTopMenu = 1
	}

	public enum States // TypeDefIndex: 7076
	{
		Init = 0,
		Start = 1,
		ReStart = 2,
		Item = 3,
		Party = 4,
		Hensei = 5,
		Quest = 6,
		DgParty = 7,
		Debug = 8,
		End = 9,
		EndGotoTop = 10,
		Etc = 11,
		RestAsk = 12,
		DebugLoad = 13,
		DebugSaveGround = 14
	}

	public class StateInit : FSMState<UIGroundMenu, States> // TypeDefIndex: 7077
	{
		// Properties
		public override States StateID { get => default; } // 0x00A82CA0-0x00A82CB0 

		// Constructors
		public StateInit() {} // 0x00A819F0-0x00A81A40

		// Methods
		public override void Enter() {} // 0x00A82CB0-0x00A82D20
		public override void Execute() {} // 0x00A82D20-0x00A82E10
		public override void Exit() {} // 0x00A82E10-0x00A82E20
	}

	public class StateStart : FSMState<UIGroundMenu, States> // TypeDefIndex: 7078
	{
		// Fields
		private UIMainMenu.ActionType act_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00A83B70-0x00A83B80 

		// Constructors
		public StateStart() {} // 0x00A81A40-0x00A81A90

		// Methods
		public override void Enter() {} // 0x00A83B80-0x00A83C60
		public override void Execute() {} // 0x00A83C60-0x00A83E80
		public override void Exit() {} // 0x00A83E80-0x00A83E90
	}

	public class StateReStart : FSMState<UIGroundMenu, States> // TypeDefIndex: 7079
	{
		// Properties
		public override States StateID { get => default; } // 0x00A83700-0x00A83710 

		// Constructors
		public StateReStart() {} // 0x00A81A90-0x00A81AE0

		// Methods
		public override void Enter() {} // 0x00A83710-0x00A83720
		public override void Execute() {} // 0x00A83720-0x00A837F0
		public override void Exit() {} // 0x00A837F0-0x00A83800
	}

	public class StateEnd : FSMState<UIGroundMenu, States> // TypeDefIndex: 7080
	{
		// Properties
		public override States StateID { get => default; } // 0x00A82000-0x00A82010 

		// Constructors
		public StateEnd() {} // 0x00A81C20-0x00A81C70

		// Methods
		public override void Enter() {} // 0x00A82010-0x00A82020
		public override void Execute() {} // 0x00A82020-0x00A82030
		public override void Exit() {} // 0x00A82030-0x00A82040
	}

	public class StateRestAsk : FSMState<UIGroundMenu, States> // TypeDefIndex: 7081
	{
		// Fields
		private bool bIsAsk; // 0x18
		private int result; // 0x1C

		// Properties
		public override States StateID { get => default; } // 0x00A83800-0x00A83810 

		// Constructors
		public StateRestAsk() {} // 0x00A81D20-0x00A81D80

		// Methods
		public override void Enter() {} // 0x00A83810-0x00A83A50
		public override void Execute() {} // 0x00A83A50-0x00A83B50
		public override void Exit() {} // 0x00A83B50-0x00A83B60
	}

	public class StateEndGotoTop : FSMState<UIGroundMenu, States> // TypeDefIndex: 7082
	{
		// Fields
		private bool bIsAsk; // 0x18
		private int result; // 0x1C

		// Properties
		public override States StateID { get => default; } // 0x00A82040-0x00A82050 

		// Constructors
		public StateEndGotoTop() {} // 0x00A81C70-0x00A81CD0

		// Methods
		public override void Enter() {} // 0x00A82050-0x00A82290
		public override void Execute() {} // 0x00A82290-0x00A82350
		public override void Exit() {} // 0x00A82350-0x00A82360
	}

	public class StateItem : FSMState<UIGroundMenu, States> // TypeDefIndex: 7083
	{
		// Fields
		private UIItemBagMenu menu_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00A82E20-0x00A82E30 

		// Constructors
		public StateItem() {} // 0x00A81AE0-0x00A81B30

		// Methods
		public override void Enter() {} // 0x00A82E30-0x00A82F50
		public override void Execute() {} // 0x00A83330-0x00A83340
		public override void Exit() {} // 0x00A83340-0x00A83350
	}

	public class StateParty : FSMState<UIGroundMenu, States> // TypeDefIndex: 7084
	{
		// Fields
		private UIStatusMenu menu_; // 0x18
		private bool bExit_; // 0x20

		// Properties
		public override States StateID { get => default; } // 0x00A833B0-0x00A833C0 

		// Constructors
		public StateParty() {} // 0x00A81B30-0x00A81B80

		// Methods
		public override void Enter() {} // 0x00A833C0-0x00A834C0
		public override void Execute() {} // 0x00A834C0-0x00A83530
		public override void Exit() {} // 0x00A83530-0x00A83540
	}

	public class StateHensei : FSMState<UIGroundMenu, States> // TypeDefIndex: 7085
	{
		// Fields
		private UIOrganizationMenu menu_; // 0x18
		private UIOrganizationMenu.ActionType act_; // 0x20

		// Properties
		public override States StateID { get => default; } // 0x00A82580-0x00A82590 

		// Constructors
		public StateHensei() {} // 0x00A81B80-0x00A81BD0

		// Methods
		public override void Enter() {} // 0x00A82590-0x00A82610
		private void _startMenu() {} // 0x00A82610-0x00A826F0
		// [IteratorStateMachine] // 0x0064CF70-0x0064CFE0
		private IEnumerator _flowWarehouse() => default; // 0x00A826F0-0x00A82760
		// [IteratorStateMachine] // 0x0064CFE0-0x0064D050
		private IEnumerator _flowBank() => default; // 0x00A82790-0x00A82800
		public override void Execute() {} // 0x00A82830-0x00A829C0
		public override void Exit() {} // 0x00A829C0-0x00A829D0
	}

	public class StateQuest : FSMState<UIGroundMenu, States> // TypeDefIndex: 7088
	{
		// Fields
		private UIGroundQuestMenu menu_; // 0x18
		private bool bExit_; // 0x20

		// Properties
		public override States StateID { get => default; } // 0x00A83550-0x00A83560 

		// Constructors
		public StateQuest() {} // 0x00A81BD0-0x00A81C20

		// Methods
		public override void Enter() {} // 0x00A83560-0x00A83660
		public override void Execute() {} // 0x00A83670-0x00A836E0
		public override void Exit() {} // 0x00A836E0-0x00A836F0
	}

	public class StateEtc : FSMState<UIGroundMenu, States> // TypeDefIndex: 7089
	{
		// Fields
		private UIOtherMenu menu_; // 0x18
		private UIOtherMenu.ActionType act_; // 0x20

		// Properties
		public override States StateID { get => default; } // 0x00A82370-0x00A82380 

		// Constructors
		public StateEtc() {} // 0x00A81CD0-0x00A81D20

		// Methods
		public override void Enter() {} // 0x00A82380-0x00A823C0
		private void _startMenu() {} // 0x00A823C0-0x00A824A0
		public override void Execute() {} // 0x00A824A0-0x00A82560
		public override void Exit() {} // 0x00A82560-0x00A82570
	}

	public class StateDgParty : FSMState<UIGroundMenu, States> // TypeDefIndex: 7090
	{
		// Fields
		private UIDungeonStatusMenu menu_; // 0x18
		private bool bExit_; // 0x20

		// Properties
		public override States StateID { get => default; } // 0x00A81E60-0x00A81E70 

		// Constructors
		public StateDgParty() {} // 0x00A81D80-0x00A81DD0

		// Methods
		public override void Enter() {} // 0x00A81E70-0x00A81F70
		public override void Execute() {} // 0x00A81F70-0x00A81FE0
		public override void Exit() {} // 0x00A81FE0-0x00A81FF0
	}

	// Constructors
	public UIGroundMenu() {} // 0x00A81430-0x00A81440

	// Methods
	// [IteratorStateMachine] // 0x00629DF0-0x00629E60
	public IEnumerator MainFlow(Action<Result> cb = null) => default; // 0x00A81380-0x00A81400
}

