/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIBulletinBoardMenu // TypeDefIndex: 6517
{
	// Fields
	private UIBulletinBoard menu_; // 0x10
	private bool bExit_; // 0x18
	public FiniteStateMachine<UIBulletinBoardMenu, States> FSM; // 0x20

	// Properties
	public UIBulletinBoard MENU { get => default; set {} } // 0x00ABF3D0-0x00ABF3E0 0x00ABF3E0-0x00ABF3F0
	public bool EXIT { get => default; set {} } // 0x00ABF3F0-0x00ABF400 0x00ABF400-0x00ABF410
	protected virtual bool POST { get => default; } // 0x00ABF410-0x00ABF420 

	// Nested types
	public enum States // TypeDefIndex: 6518
	{
		Init = 0,
		Start = 1,
		BulletinBoard = 2,
		RequestsReceived = 3,
		ReadTheNews = 4,
		WatchThePost = 5,
		Close = 6,
		End = 7
	}

	public class StateInit : FSMState<UIBulletinBoardMenu, States> // TypeDefIndex: 6519
	{
		// Properties
		public override States StateID { get => default; } // 0x00AC0050-0x00AC0060 

		// Constructors
		public StateInit() {} // 0x00ABF8D0-0x00ABF920

		// Methods
		public override void Enter() {} // 0x00AC0060-0x00AC0090
		public override void Execute() {} // 0x00AC0090-0x00AC00F0
		public override void Exit() {} // 0x00AC00F0-0x00AC0100
	}

	public class StateStart : FSMState<UIBulletinBoardMenu, States> // TypeDefIndex: 6520
	{
		// Fields
		private UIBulletinBoard.TopMenuSelectType sel_; // 0x18
		private int cursor_; // 0x1C

		// Properties
		public override States StateID { get => default; } // 0x00AC0420-0x00AC0430 

		// Constructors
		public StateStart() {} // 0x00ABF920-0x00ABF970

		// Methods
		public override void Enter() {} // 0x00AC0430-0x00AC05C0
		public override void Execute() {} // 0x00AC05C0-0x00AC0700
		public override void Exit() {} // 0x00AC0700-0x00AC0710
	}

	public class StateClose : FSMState<UIBulletinBoardMenu, States> // TypeDefIndex: 6521
	{
		// Fields
		private bool bExit_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00ABFE20-0x00ABFE30 

		// Constructors
		public StateClose() {} // 0x00ABFAB0-0x00ABFB00

		// Methods
		public override void Enter() {} // 0x00ABFE30-0x00ABFF50
		public override void Execute() {} // 0x00ABFF50-0x00ABFFC0
		public override void Exit() {} // 0x00ABFFC0-0x00ABFFD0
	}

	public class StateEnd : FSMState<UIBulletinBoardMenu, States> // TypeDefIndex: 6522
	{
		// Properties
		public override States StateID { get => default; } // 0x00ABFFE0-0x00ABFFF0 

		// Constructors
		public StateEnd() {} // 0x00ABFB00-0x00ABFB50

		// Methods
		public override void Enter() {} // 0x00ABFFF0-0x00AC0030
		public override void Execute() {} // 0x00AC0030-0x00AC0040
		public override void Exit() {} // 0x00AC0040-0x00AC0050
	}

	public class StateBulletinBoard : FSMState<UIBulletinBoardMenu, States> // TypeDefIndex: 6523
	{
		// Fields
		private UIBulletinBoard.BillboardQuestSelectType sel_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00ABFBE0-0x00ABFBF0 

		// Constructors
		public StateBulletinBoard() {} // 0x00ABF970-0x00ABF9C0

		// Methods
		public override void Enter() {} // 0x00ABFBF0-0x00ABFCE0
		public override void Execute() {} // 0x00ABFCE0-0x00ABFE00
		public override void Exit() {} // 0x00ABFE00-0x00ABFE10
	}

	public class StateRequestsReceived : FSMState<UIBulletinBoardMenu, States> // TypeDefIndex: 6524
	{
		// Fields
		private UIBulletinBoard.TrustQuestSelectType sel_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00AC0290-0x00AC02A0 

		// Constructors
		public StateRequestsReceived() {} // 0x00ABF9C0-0x00ABFA10

		// Methods
		public override void Enter() {} // 0x00AC02A0-0x00AC0390
		public override void Execute() {} // 0x00AC0390-0x00AC0400
		public override void Exit() {} // 0x00AC0400-0x00AC0410
	}

	public class StateReadTheNews : FSMState<UIBulletinBoardMenu, States> // TypeDefIndex: 6525
	{
		// Fields
		private UIBulletinBoard.NewsBoardSelectType sel_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00AC0100-0x00AC0110 

		// Constructors
		public StateReadTheNews() {} // 0x00ABFA10-0x00ABFA60

		// Methods
		public override void Enter() {} // 0x00AC0110-0x00AC0200
		public override void Execute() {} // 0x00AC0200-0x00AC0270
		public override void Exit() {} // 0x00AC0270-0x00AC0280
	}

	public class StateWatchThePost : FSMState<UIBulletinBoardMenu, States> // TypeDefIndex: 6526
	{
		// Fields
		private UIBulletinBoard.MailBoxSelectType sel_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00AC0730-0x00AC0740 

		// Constructors
		public StateWatchThePost() {} // 0x00ABFA60-0x00ABFAB0

		// Methods
		public override void Enter() {} // 0x00AC0740-0x00AC0830
		public override void Execute() {} // 0x00AC0830-0x00AC08A0
		public override void Exit() {} // 0x00AC08A0-0x00AC08B0
	}

	// Constructors
	public UIBulletinBoardMenu() {} // 0x00ABF4D0-0x00ABF4E0

	// Methods
	// [IteratorStateMachine] // 0x00627910-0x00627980
	public virtual IEnumerator MainFlow(Action cb = null) => default; // 0x00ABF420-0x00ABF4A0
}

