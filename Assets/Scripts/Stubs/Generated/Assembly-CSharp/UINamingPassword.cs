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

public class UINamingPassword : UINaming // TypeDefIndex: 7185
{
	// Fields
	public FiniteStateMachine<UINamingPassword, States> FSM; // 0x58
	private NamingPasswordEnterTextWindow namingPasswordEnterTextWindow_; // 0x60

	// Nested types
	protected class NamingPasswordEnterTextWindow : UINaming.NamingEnterTextWindow // TypeDefIndex: 7186
	{
		// Fields
		protected UINamingPassword manager_; // 0x100
		protected GameObject passTouchIcon; // 0x108
		protected GameObject passCheckList; // 0x110
		protected int DisplayInput; // 0x118
		protected int MaxPasswordInputNumPerLine; // 0x11C
		protected int PassMaxLineNum; // 0x120

		// Constructors
		public NamingPasswordEnterTextWindow() {} // 0x00DE3340-0x00DE3360

		// Methods
		public override void Init(GameObject root, UINaming manager, UINamingControl.NamingParam param) {} // 0x00DE3CE0-0x00DE3EE0
		protected override void SelectOut(GameObject obj) {} // 0x00DE3EE0-0x00DE3FF0
		protected override void InitialSet(string text) {} // 0x00DE3FF0-0x00DE42D0
		protected override void PaletteInit() {} // 0x00DE42D0-0x00DE4A40
		protected override void InputWindowInit(GameObject inputWindow) {} // 0x00DE4A40-0x00DE5010
		protected override void PaletteMake(LanguagePalette[,] palette) {} // 0x00DE5010-0x00DE54B0
		public void ImageDisable(GameObject obj) {} // 0x00DE54B0-0x00DE5610
		protected override bool _doPaletteChange() => default; // 0x00DE5610-0x00DE5620
		protected override bool _doFormChange() => default; // 0x00DE5620-0x00DE5630
		protected override bool _doShiftRight() => default; // 0x00DE5630-0x00DE5650
		protected override void CursorSet(int SetNum) {} // 0x00DE5650-0x00DE5700
		protected override bool _doDecide() => default; // 0x00DE5700-0x00DE58C0
		protected override void _doFinish() {} // 0x00DE58C0-0x00DE5970
		protected override void _doInputWord(int X, int Y, bool bSound = true /* Metadata: 0x006134B4 */) {} // 0x00DE5970-0x00DE5DC0
		protected override void _doTempInputWord(int X, int Y) {} // 0x00DE5DC0-0x00DE5DD0
		protected override void doPack() {} // 0x00DE5DD0-0x00DE6110
		protected override void doPush(int start) {} // 0x00DE6110-0x00DE6470
		protected override void SetEnterText() {} // 0x00DE6470-0x00DE6730
		protected override void GetEnterText() {} // 0x00DE6730-0x00DE6870
		protected string ConvertMarkToString(GameObject gameObject) => default; // 0x00DE6870-0x00DE6AD0
	}

	public class StateInit : FSMState<UINamingPassword, States> // TypeDefIndex: 7187
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE6C80-0x00DE6C90 

		// Constructors
		public StateInit() {} // 0x00DE3360-0x00DE33B0

		// Methods
		public override void Enter() {} // 0x00DE6C90-0x00DE6CA0
		public override void Execute() {} // 0x00DE6CA0-0x00DE6CB0
		public override void Exit() {} // 0x00DE6CB0-0x00DE6CC0
	}

	public class StateStart : FSMState<UINamingPassword, States> // TypeDefIndex: 7188
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE6CC0-0x00DE6CD0 

		// Constructors
		public StateStart() {} // 0x00DE33B0-0x00DE3400

		// Methods
		public override void Enter() {} // 0x00DE6CD0-0x00DE6DC0
		public override void Execute() {} // 0x00DE6DC0-0x00DE6DE0
		public override void Exit() {} // 0x00DE6DE0-0x00DE6DF0
	}

	public class StateFinish : FSMState<UINamingPassword, States> // TypeDefIndex: 7189
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE6C30-0x00DE6C40 

		// Constructors
		public StateFinish() {} // 0x00DE3400-0x00DE3450

		// Methods
		public override void Enter() {} // 0x00DE6C40-0x00DE6C60
		public override void Execute() {} // 0x00DE6C60-0x00DE6C70
		public override void Exit() {} // 0x00DE6C70-0x00DE6C80
	}

	public class StateEnd : FSMState<UINamingPassword, States> // TypeDefIndex: 7190
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE6BF0-0x00DE6C00 

		// Constructors
		public StateEnd() {} // 0x00DE3450-0x00DE34A0

		// Methods
		public override void Enter() {} // 0x00DE6C00-0x00DE6C10
		public override void Execute() {} // 0x00DE6C10-0x00DE6C20
		public override void Exit() {} // 0x00DE6C20-0x00DE6C30
	}

	public class StateDecide : FSMState<UINamingPassword, States> // TypeDefIndex: 7191
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE6B60-0x00DE6B70 

		// Constructors
		public StateDecide() {} // 0x00DE34A0-0x00DE34F0

		// Methods
		public override void Enter() {} // 0x00DE6B70-0x00DE6B80
		public override void Execute() {} // 0x00DE6B80-0x00DE6BE0
		public override void Exit() {} // 0x00DE6BE0-0x00DE6BF0
	}

	public class StateCancel : FSMState<UINamingPassword, States> // TypeDefIndex: 7192
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE6AD0-0x00DE6AE0 

		// Constructors
		public StateCancel() {} // 0x00DE34F0-0x00DE3540

		// Methods
		public override void Enter() {} // 0x00DE6AE0-0x00DE6AF0
		public override void Execute() {} // 0x00DE6AF0-0x00DE6B50
		public override void Exit() {} // 0x00DE6B50-0x00DE6B60
	}

	// Constructors
	public UINamingPassword() {} // 0x00DE39F0-0x00DE3A00

	// Methods
	public static UINamingPassword Create() => default; // 0x00DDCA20-0x00DDCB20
	public override void Construct() {} // 0x00DE3010-0x00DE3340
	public override void Init(UINamingControl.NamingParam namingParam) {} // 0x00DE3540-0x00DE3590
	// [IteratorStateMachine] // 0x0062AAC0-0x0062AB30
	public override IEnumerator MainFlow(Action<bool> resultCb, Action<string> TextCb, Action<EnterTextWindow.ActionType> actTypeCb) => default; // 0x00DE3590-0x00DE3620
	// [IteratorStateMachine] // 0x0062AB30-0x0062ABA0
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00DE3650-0x00DE36D0
	protected override void _cbFromNamingWindow(EnterTextWindow.ActionType act) {} // 0x00DE3700-0x00DE38A0
	public override void DoOpenEnter() {} // 0x00DE38A0-0x00DE3930
	public override void DoCloseEnter() {} // 0x00DE3930-0x00DE3990
	private new void Update() {} // 0x00DE3990-0x00DE39F0
}

