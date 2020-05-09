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

public class UINamingNAEdition : UINaming // TypeDefIndex: 7165
{
	// Fields
	protected const int MaxNamingInputNum = 12; // Metadata: 0x006134AD
	public FiniteStateMachine<UINamingNAEdition, States> FSM; // 0x58
	private NamingNAEditionEnterTextWindow namingNAEditionEnterTextWindow_; // 0x60

	// Nested types
	private class NamingNAEditionEnterTextWindow : UINaming.NamingEnterTextWindow // TypeDefIndex: 7166
	{
		// Fields
		protected UINamingNAEdition manager_; // 0x100
		protected string visibleText; // 0x108
		protected string tempVisibleText; // 0x110
		protected Vector3 InitialPos; // 0x118
		protected float scoreLength; // 0x124
		private GameObject UnderScore; // 0x128
		private UIControlTMP TextComp; // 0x130
		private UINamingTMPColor TextCompColor; // 0x138
		private float textScale; // 0x140
		protected bool bEnoughTextLength; // 0x144

		// Constructors
		public NamingNAEditionEnterTextWindow() {} // 0x00DDDCA0-0x00DDDCB0

		// Methods
		public override void Init(GameObject root, UINaming manager, UINamingControl.NamingParam param) {} // 0x00DDE5D0-0x00DDE7E0
		protected override void PaletteInit() {} // 0x00DDE8B0-0x00DDEFB0
		protected override void InputWindowInit(GameObject inputWindow) {} // 0x00DDEFB0-0x00DDF3B0
		protected override void CursorSet() {} // 0x00DDF3B0-0x00DDF4B0
		protected override void CursorSet(int SetNum) {} // 0x00DDF4B0-0x00DDF590
		protected void TextSet() {} // 0x00DDE7E0-0x00DDE8B0
		protected void TextTempSet() {} // 0x00DDF590-0x00DDF5F0
		protected override bool _doShiftLeft() => default; // 0x00DDF5F0-0x00DDF730
		protected override bool _doShiftRight() => default; // 0x00DDF730-0x00DDF8D0
		protected override bool _doTouchEnded(Vector3 touch) => default; // 0x00DDF8D0-0x00DE0410
		protected override bool _doTouchAnimation(Vector2 touch, TouchPhase phase) => default; // 0x00DE0410-0x00DE1470
		protected override bool _doEnter(int x, int y, bool bTouch = false /* Metadata: 0x006134B1 */) => default; // 0x00DE1470-0x00DE15E0
		protected override bool _doTempEnter(int x, int y) => default; // 0x00DE1AA0-0x00DE1B60
		protected override bool _doCancel() => default; // 0x00DE1B60-0x00DE1CB0
		protected override bool _doDelete() => default; // 0x00DE1CB0-0x00DE1D80
		protected override bool _doFormChange() => default; // 0x00DE1D80-0x00DE1FB0
		protected override bool _doPaletteChange() => default; // 0x00DE1FB0-0x00DE20A0
		protected override void _doInputWord(int presentX, int presentY, bool bSound = true /* Metadata: 0x006134B2 */) {} // 0x00DE20A0-0x00DE25B0
		protected override void _doTempInputWord(int presentX, int presentY) {} // 0x00DE25B0-0x00DE29D0
		protected void doPaletteChangeABC() {} // 0x00DE15E0-0x00DE1840
		protected void doPaletteChangeOther() {} // 0x00DE1840-0x00DE1AA0
		protected override bool doSpecial() => default; // 0x00DE29E0-0x00DE2B90
		protected override void GetEnterText() {} // 0x00DE2B90-0x00DE2BA0
		protected override void SetEnterText() {} // 0x00DE2BA0-0x00DE2C10
		protected override void _doFinish() {} // 0x00DE2C10-0x00DE2CC0
		protected override bool SkipAnimation() => default; // 0x00DE2CC0-0x00DE2CD0
	}

	public class StateInit : FSMState<UINamingNAEdition, States> // TypeDefIndex: 7167
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE2E80-0x00DE2E90 

		// Constructors
		public StateInit() {} // 0x00DDDCB0-0x00DDDD00

		// Methods
		public override void Enter() {} // 0x00DE2E90-0x00DE2EA0
		public override void Execute() {} // 0x00DE2EA0-0x00DE2EB0
		public override void Exit() {} // 0x00DE2EB0-0x00DE2EC0
	}

	public class StateStart : FSMState<UINamingNAEdition, States> // TypeDefIndex: 7168
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE2EC0-0x00DE2ED0 

		// Constructors
		public StateStart() {} // 0x00DDDD00-0x00DDDD50

		// Methods
		public override void Enter() {} // 0x00DE2ED0-0x00DE2FC0
		public override void Execute() {} // 0x00DE2FC0-0x00DE2FE0
		public override void Exit() {} // 0x00DE2FE0-0x00DE2FF0
	}

	public class StateFinish : FSMState<UINamingNAEdition, States> // TypeDefIndex: 7169
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE2E30-0x00DE2E40 

		// Constructors
		public StateFinish() {} // 0x00DDDD50-0x00DDDDA0

		// Methods
		public override void Enter() {} // 0x00DE2E40-0x00DE2E60
		public override void Execute() {} // 0x00DE2E60-0x00DE2E70
		public override void Exit() {} // 0x00DE2E70-0x00DE2E80
	}

	public class StateEnd : FSMState<UINamingNAEdition, States> // TypeDefIndex: 7170
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE2DF0-0x00DE2E00 

		// Constructors
		public StateEnd() {} // 0x00DDDDA0-0x00DDDDF0

		// Methods
		public override void Enter() {} // 0x00DE2E00-0x00DE2E10
		public override void Execute() {} // 0x00DE2E10-0x00DE2E20
		public override void Exit() {} // 0x00DE2E20-0x00DE2E30
	}

	public class StateDecide : FSMState<UINamingNAEdition, States> // TypeDefIndex: 7171
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE2D60-0x00DE2D70 

		// Constructors
		public StateDecide() {} // 0x00DDDDF0-0x00DDDE40

		// Methods
		public override void Enter() {} // 0x00DE2D70-0x00DE2D80
		public override void Execute() {} // 0x00DE2D80-0x00DE2DE0
		public override void Exit() {} // 0x00DE2DE0-0x00DE2DF0
	}

	public class StateCancel : FSMState<UINamingNAEdition, States> // TypeDefIndex: 7172
	{
		// Properties
		public override UINaming.States StateID { get => default; } // 0x00DE2CD0-0x00DE2CE0 

		// Constructors
		public StateCancel() {} // 0x00DDDE40-0x00DDDE90

		// Methods
		public override void Enter() {} // 0x00DE2CE0-0x00DE2CF0
		public override void Execute() {} // 0x00DE2CF0-0x00DE2D50
		public override void Exit() {} // 0x00DE2D50-0x00DE2D60
	}

	// Constructors
	public UINamingNAEdition() {} // 0x00DDE2C0-0x00DDE2D0

	// Methods
	public static UINamingNAEdition Create() => default; // 0x00DDD5C0-0x00DDD6C0
	public override void Construct() {} // 0x00DDD980-0x00DDDCA0
	public override void Init(UINamingControl.NamingParam namingParam) {} // 0x00DDDE90-0x00DDDEE0
	// [IteratorStateMachine] // 0x0062A900-0x0062A970
	public override IEnumerator MainFlow(Action<bool> resultCb, Action<string> TextCb, Action<EnterTextWindow.ActionType> actTypeCb) => default; // 0x00DDDEE0-0x00DDDF70
	public override List<string> GetNameList() => default; // 0x00DDDFA0-0x00DDDFB0
	public override string GetInitText() => default; // 0x00DDDFB0-0x00DDDFC0
	protected override void _cbFromNamingWindow(EnterTextWindow.ActionType act) {} // 0x00DDDFC0-0x00DDE0C0
	// [IteratorStateMachine] // 0x0062A970-0x0062A9E0
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00DDE0C0-0x00DDE140
	public override void DoOpenEnter() {} // 0x00DDE170-0x00DDE200
	public override void DoCloseEnter() {} // 0x00DDE200-0x00DDE260
	private new void Update() {} // 0x00DDE260-0x00DDE2C0
}

