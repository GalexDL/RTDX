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

public class UINamingPasswordOld : UINaming // TypeDefIndex: 7175
{
	// Fields
	public FiniteStateMachine<UINamingPasswordOld, States> FSM; // 0x58
	private NamingPasswordEnterTextWindow namingPasswordEnterTextWindow_; // 0x60

	// Nested types
	protected class NamingPasswordEnterTextWindow : UINaming.NamingEnterTextWindow // TypeDefIndex: 7176
	{
		// Fields
		protected UINamingPasswordOld manager_; // 0x100
		protected GameObject passTouchIcon; // 0x108
		protected GameObject passCheckList; // 0x110
		protected int DisplayInput; // 0x118
		protected int MaxPasswordInputNumPerLine; // 0x11C
		protected int PassMaxLineNum; // 0x120

		// Constructors
		public NamingPasswordEnterTextWindow() {} // 0x00DE7240-0x00DE7260

		// Methods
		public override void Init(GameObject root, UINaming manager, UINamingControl.NamingParam param) {} // 0x00DE7BE0-0x00DE7DA0
		protected override void PaletteInit() {} // 0x00DE7DA0-0x00DE8320
		protected override void InputWindowInit(GameObject inputWindow) {} // 0x00DE8320-0x00DE88F0
		protected override void PaletteMake(LanguagePalette[,] palette) {} // 0x00DE88F0-0x00DE8F60
		public void ImageDisable(GameObject obj) {} // 0x00DE8F60-0x00DE90C0
		protected override bool _doPaletteChange() => default; // 0x00DE90C0-0x00DE90D0
		protected override bool _doFormChange() => default; // 0x00DE90D0-0x00DE90E0
		protected override void _doFinish() {} // 0x00DE90E0-0x00DE9190
		protected override void _doInputWord(int X, int Y, bool bSound = true /* Metadata: 0x006134B3 */) {} // 0x00DE9190-0x00DE9380
		protected override void _doTempInputWord(int X, int Y) {} // 0x00DE9380-0x00DE94B0
	}

	public class StateInit : FSMState<UINamingPasswordOld, States> // TypeDefIndex: 7177
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE9660-0x00DE9670 

		// Constructors
		public StateInit() {} // 0x00DE7260-0x00DE72B0

		// Methods
		public override void Enter() {} // 0x00DE9670-0x00DE9680
		public override void Execute() {} // 0x00DE9680-0x00DE9690
		public override void Exit() {} // 0x00DE9690-0x00DE96A0
	}

	public class StateStart : FSMState<UINamingPasswordOld, States> // TypeDefIndex: 7178
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE96A0-0x00DE96B0 

		// Constructors
		public StateStart() {} // 0x00DE72B0-0x00DE7300

		// Methods
		public override void Enter() {} // 0x00DE96B0-0x00DE97A0
		public override void Execute() {} // 0x00DE97A0-0x00DE97C0
		public override void Exit() {} // 0x00DE97C0-0x00DE97D0
	}

	public class StateFinish : FSMState<UINamingPasswordOld, States> // TypeDefIndex: 7179
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE9610-0x00DE9620 

		// Constructors
		public StateFinish() {} // 0x00DE7300-0x00DE7350

		// Methods
		public override void Enter() {} // 0x00DE9620-0x00DE9640
		public override void Execute() {} // 0x00DE9640-0x00DE9650
		public override void Exit() {} // 0x00DE9650-0x00DE9660
	}

	public class StateEnd : FSMState<UINamingPasswordOld, States> // TypeDefIndex: 7180
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE95D0-0x00DE95E0 

		// Constructors
		public StateEnd() {} // 0x00DE7350-0x00DE73A0

		// Methods
		public override void Enter() {} // 0x00DE95E0-0x00DE95F0
		public override void Execute() {} // 0x00DE95F0-0x00DE9600
		public override void Exit() {} // 0x00DE9600-0x00DE9610
	}

	public class StateDecide : FSMState<UINamingPasswordOld, States> // TypeDefIndex: 7181
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE9540-0x00DE9550 

		// Constructors
		public StateDecide() {} // 0x00DE73A0-0x00DE73F0

		// Methods
		public override void Enter() {} // 0x00DE9550-0x00DE9560
		public override void Execute() {} // 0x00DE9560-0x00DE95C0
		public override void Exit() {} // 0x00DE95C0-0x00DE95D0
	}

	public class StateCancel : FSMState<UINamingPasswordOld, States> // TypeDefIndex: 7182
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE94B0-0x00DE94C0 

		// Constructors
		public StateCancel() {} // 0x00DE73F0-0x00DE7440

		// Methods
		public override void Enter() {} // 0x00DE94C0-0x00DE94D0
		public override void Execute() {} // 0x00DE94D0-0x00DE9530
		public override void Exit() {} // 0x00DE9530-0x00DE9540
	}

	// Constructors
	public UINamingPasswordOld() {} // 0x00DE78F0-0x00DE7900

	// Methods
	public static UINamingPasswordOld Create() => default; // 0x00DE6E10-0x00DE6F10
	public override void Construct() {} // 0x00DE6F10-0x00DE7240
	public override void Init(UINamingControl.NamingParam namingParam) {} // 0x00DE7440-0x00DE7490
	// [IteratorStateMachine] // 0x0062A9E0-0x0062AA50
	public override IEnumerator MainFlow(Action<bool> resultCb, Action<string> TextCb, Action<EnterTextWindow.ActionType> actTypeCb) => default; // 0x00DE7490-0x00DE7520
	// [IteratorStateMachine] // 0x0062AA50-0x0062AAC0
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00DE7550-0x00DE75D0
	protected override void _cbFromNamingWindow(EnterTextWindow.ActionType act) {} // 0x00DE7600-0x00DE77A0
	public override void DoOpenEnter() {} // 0x00DE77A0-0x00DE7830
	public override void DoCloseEnter() {} // 0x00DE7830-0x00DE7890
	private new void Update() {} // 0x00DE7890-0x00DE78F0
}

