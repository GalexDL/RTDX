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

public class UINamingWonderMail : UINamingPasswordOld // TypeDefIndex: 7196
{
	// Fields
	public FiniteStateMachine<UINamingWonderMail, States> FSM; // 0x68
	private NamingMailEnterTextWindow namingMailEnterTextWindow_; // 0x70

	// Nested types
	private class NamingMailEnterTextWindow : UINamingPasswordOld.NamingPasswordEnterTextWindow // TypeDefIndex: 7197
	{
		// Fields
		protected UINamingWonderMail manager_; // 0x128
		public bool bUserId; // 0x130

		// Constructors
		public NamingMailEnterTextWindow() {} // 0x00DE9CA0-0x00DE9CC0

		// Methods
		public override void Init(GameObject root, UINaming manager, UINamingControl.NamingParam param) {} // 0x00DEA640-0x00DEA880
		protected override void InputWindowInit(GameObject inputWindow) {} // 0x00DEA880-0x00DEAC80
		protected override void PaletteInit() {} // 0x00DEAC80-0x00DEB1E0
		protected override void PaletteMake(LanguagePalette[,] palette) {} // 0x00DEB1E0-0x00DEB8D0
		protected override void _doFinish() {} // 0x00DEB8D0-0x00DEB980
		protected override bool _doShiftRight() => default; // 0x00DEB980-0x00DEB9A0
		protected override void _doInput() {} // 0x00DEB9A0-0x00DEB9B0
	}

	public class StateInit : FSMState<UINamingWonderMail, States> // TypeDefIndex: 7198
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DEBB60-0x00DEBB70 

		// Constructors
		public StateInit() {} // 0x00DE9CC0-0x00DE9D10

		// Methods
		public override void Enter() {} // 0x00DEBB70-0x00DEBB80
		public override void Execute() {} // 0x00DEBB80-0x00DEBB90
		public override void Exit() {} // 0x00DEBB90-0x00DEBBA0
	}

	public class StateStart : FSMState<UINamingWonderMail, States> // TypeDefIndex: 7199
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DEBBA0-0x00DEBBB0 

		// Constructors
		public StateStart() {} // 0x00DE9D10-0x00DE9D60

		// Methods
		public override void Enter() {} // 0x00DEBBB0-0x00DEBCA0
		public override void Execute() {} // 0x00DEBCA0-0x00DEBCC0
		public override void Exit() {} // 0x00DEBCC0-0x00DEBCD0
	}

	public class StateFinish : FSMState<UINamingWonderMail, States> // TypeDefIndex: 7200
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DEBB10-0x00DEBB20 

		// Constructors
		public StateFinish() {} // 0x00DE9D60-0x00DE9DB0

		// Methods
		public override void Enter() {} // 0x00DEBB20-0x00DEBB40
		public override void Execute() {} // 0x00DEBB40-0x00DEBB50
		public override void Exit() {} // 0x00DEBB50-0x00DEBB60
	}

	public class StateEnd : FSMState<UINamingWonderMail, States> // TypeDefIndex: 7201
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DEBAD0-0x00DEBAE0 

		// Constructors
		public StateEnd() {} // 0x00DE9DB0-0x00DE9E00

		// Methods
		public override void Enter() {} // 0x00DEBAE0-0x00DEBAF0
		public override void Execute() {} // 0x00DEBAF0-0x00DEBB00
		public override void Exit() {} // 0x00DEBB00-0x00DEBB10
	}

	public class StateDecide : FSMState<UINamingWonderMail, States> // TypeDefIndex: 7202
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DEBA40-0x00DEBA50 

		// Constructors
		public StateDecide() {} // 0x00DE9E00-0x00DE9E50

		// Methods
		public override void Enter() {} // 0x00DEBA50-0x00DEBA60
		public override void Execute() {} // 0x00DEBA60-0x00DEBAC0
		public override void Exit() {} // 0x00DEBAC0-0x00DEBAD0
	}

	public class StateCancel : FSMState<UINamingWonderMail, States> // TypeDefIndex: 7203
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DEB9B0-0x00DEB9C0 

		// Constructors
		public StateCancel() {} // 0x00DE9E50-0x00DE9EA0

		// Methods
		public override void Enter() {} // 0x00DEB9C0-0x00DEB9D0
		public override void Execute() {} // 0x00DEB9D0-0x00DEBA30
		public override void Exit() {} // 0x00DEBA30-0x00DEBA40
	}

	// Constructors
	public UINamingWonderMail() {} // 0x00DEA280-0x00DEA290

	// Methods
	public static UINamingWonderMail Create() => default; // 0x00DDCB20-0x00DDCC20
	public override void Construct() {} // 0x00DE9970-0x00DE9CA0
	public override void Init(UINamingControl.NamingParam param) {} // 0x00DE9EA0-0x00DE9EF0
	public void SetUserId(bool isId) {} // 0x00DDCC20-0x00DDCC30
	// [IteratorStateMachine] // 0x0062ABA0-0x0062AC10
	public override IEnumerator MainFlow(Action<bool> resultCb, Action<string> TextCb, Action<EnterTextWindow.ActionType> actTypeCb) => default; // 0x00DE9EF0-0x00DE9F80
	// [IteratorStateMachine] // 0x0062AC10-0x0062AC80
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00DE9FB0-0x00DEA030
	protected override void _cbFromNamingWindow(EnterTextWindow.ActionType act) {} // 0x00DEA060-0x00DEA130
	public override void DoOpenEnter() {} // 0x00DEA130-0x00DEA1C0
	public override void DoCloseEnter() {} // 0x00DEA1C0-0x00DEA220
	private new void Update() {} // 0x00DEA220-0x00DEA280
}

