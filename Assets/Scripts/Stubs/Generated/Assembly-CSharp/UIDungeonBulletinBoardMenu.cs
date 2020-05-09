/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIDungeonBulletinBoardMenu // TypeDefIndex: 6531
{
	// Fields
	private UIDungeonBulletinBoard menu_; // 0x10
	private bool bExit_; // 0x18
	protected bool bSingleCall; // 0x19
	public FiniteStateMachine<UIDungeonBulletinBoardMenu, States> FSM; // 0x20

	// Properties
	public UIDungeonBulletinBoard MENU { get => default; set {} } // 0x00B1E720-0x00B1E730 0x00B1E730-0x00B1E740
	public bool EXIT { get => default; set {} } // 0x00B1E740-0x00B1E750 0x00B1E750-0x00B1E760

	// Nested types
	public enum States // TypeDefIndex: 6532
	{
		Init = 0,
		Start = 1,
		Close = 2,
		End = 3
	}

	public class StateInit : FSMState<UIDungeonBulletinBoardMenu, States> // TypeDefIndex: 6533
	{
		// Properties
		public override States StateID { get => default; } // 0x00B1F0A0-0x00B1F0B0 

		// Constructors
		public StateInit() {} // 0x00B1EAC0-0x00B1EB10

		// Methods
		public override void Enter() {} // 0x00B1F0B0-0x00B1F0E0
		public override void Execute() {} // 0x00B1F0E0-0x00B1F140
		public override void Exit() {} // 0x00B1F140-0x00B1F150
	}

	public class StateDungeonRequestsReceived : FSMState<UIDungeonBulletinBoardMenu, States> // TypeDefIndex: 6534
	{
		// Fields
		private UIDungeonBulletinBoard.TrustQuestSelectType sel_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00B1EE50-0x00B1EE60 

		// Constructors
		public StateDungeonRequestsReceived() {} // 0x00B1EB10-0x00B1EB60

		// Methods
		public override void Enter() {} // 0x00B1EE60-0x00B1EFA0
		public override void Execute() {} // 0x00B1EFA0-0x00B1F010
		public override void Exit() {} // 0x00B1F010-0x00B1F020
	}

	public class StateClose : FSMState<UIDungeonBulletinBoardMenu, States> // TypeDefIndex: 6535
	{
		// Fields
		private bool bExit_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00B1EC90-0x00B1ECA0 

		// Constructors
		public StateClose() {} // 0x00B1EB60-0x00B1EBB0

		// Methods
		public override void Enter() {} // 0x00B1ECA0-0x00B1EDC0
		public override void Execute() {} // 0x00B1EDC0-0x00B1EE30
		public override void Exit() {} // 0x00B1EE30-0x00B1EE40
	}

	public class StateEnd : FSMState<UIDungeonBulletinBoardMenu, States> // TypeDefIndex: 6536
	{
		// Properties
		public override States StateID { get => default; } // 0x00B1F030-0x00B1F040 

		// Constructors
		public StateEnd() {} // 0x00B1EBB0-0x00B1EC00

		// Methods
		public override void Enter() {} // 0x00B1F040-0x00B1F080
		public override void Execute() {} // 0x00B1F080-0x00B1F090
		public override void Exit() {} // 0x00B1F090-0x00B1F0A0
	}

	// Constructors
	public UIDungeonBulletinBoardMenu() {} // 0x00B1E820-0x00B1E830

	// Methods
	public void SetSingleCall() {} // 0x00B1E760-0x00B1E770
	// [IteratorStateMachine] // 0x006279F0-0x00627A60
	public IEnumerator MainFlow(Action cb = null) => default; // 0x00B1E770-0x00B1E7F0
}

