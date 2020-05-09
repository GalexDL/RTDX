/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIGroundQuestMenu : UIBulletinBoardMenu // TypeDefIndex: 6528
{
	// Nested types
	public class StateGroundRequestsReceived : FSMState<UIBulletinBoardMenu, States> // TypeDefIndex: 6529
	{
		// Fields
		private UIBulletinBoard.TrustQuestSelectType sel_; // 0x18

		// Properties
		public override UIBulletinBoardMenu.States StateID { get => default; } // 0x00A84260-0x00A84270 

		// Constructors
		public StateGroundRequestsReceived() {} // 0x00A84180-0x00A841D0

		// Methods
		public override void Enter() {} // 0x00A84270-0x00A84370
		public override void Execute() {} // 0x00A84370-0x00A843E0
		public override void Exit() {} // 0x00A843E0-0x00A84400
	}

	// Constructors
	public UIGroundQuestMenu() {} // 0x00A83660-0x00A83670

	// Methods
	// [IteratorStateMachine] // 0x00627980-0x006279F0
	public override IEnumerator MainFlow(Action cb = null) => default; // 0x00A83EA0-0x00A83F20
}

