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

public class UINaming : UIManagerBase // TypeDefIndex: 7129
{
	// Fields
	protected const int MaxNamingInputNum = 6; // Metadata: 0x0061341F
	protected CommonScreen commonScreenNaming_; // 0x20
	protected bool bCancel_; // 0x28
	protected string rtnText; // 0x30
	protected EnterTextWindow.ActionType actionType; // 0x38
	public FiniteStateMachine<UINaming, States> FSM; // 0x40
	private NamingEnterTextWindow namingEnterTextWindow_; // 0x48
	protected bool bEnd_; // 0x50

	// Nested types
	public enum States // TypeDefIndex: 7130
	{
		Init = 0,
		Start = 1,
		Finish = 2,
		End = 3,
		Decide = 4,
		Cancel = 5
	}

	protected class NamingEnterTextWindow : EnterTextWindow // TypeDefIndex: 7131
	{
		// Fields
		protected UINaming manager_; // 0x60
		protected GameObject root_; // 0x68
		protected GameObject Set; // 0x70
		protected GameObject[,] key; // 0x78
		protected GameObject buttonL; // 0x80
		protected GameObject buttonR; // 0x88
		protected GameObject buttonSP; // 0x90
		protected GameObject Cursor; // 0x98
		protected GameObject[] line; // 0xA0
		protected GameObject inputWindow; // 0xA8
		public List<string> RandomNameCandidate; // 0xB0
		protected LanguagePalette[,] Palette; // 0xB8
		protected float offset; // 0xC0
		protected float cursorWidth; // 0xC4
		public string enterText; // 0xC8
		public string initText; // 0xD0
		protected bool bExitB; // 0xD8
		protected bool bTempText; // 0xD9
		protected bool bSpecialButton; // 0xDA
		protected bool teamNameFirstSwitch; // 0xDB
		protected int logY; // 0xDC
		protected bool bPressedL; // 0xE0
		protected bool bPressedR; // 0xE1
		protected bool bCursoredSpecial; // 0xE2
		protected bool bPressedSpecial; // 0xE3
		protected bool strageEnterText; // 0xE4
		protected float LongPressTime; // 0xE8
		protected float waitTime; // 0xEC
		protected float invokeInterval; // 0xF0
		protected bool isInvokeEvent; // 0xF4
		protected bool IsThisINS; // 0xF5
		private bool animationL; // 0xF6
		private bool animationR; // 0xF7
		public bool animationEnd; // 0xF8

		// Constructors
		public NamingEnterTextWindow() {} // 0x00958B20-0x00958BC0

		// Methods
		public virtual void Init(GameObject root, UINaming manager, UINamingControl.NamingParam param) {} // 0x00959330-0x00959520
		protected virtual void PrefabInit() {} // 0x00959520-0x00959790
		protected virtual void PaletteInit() {} // 0x00959790-0x00959D40
		protected virtual void InputWindowInit(GameObject inputWindow) {} // 0x0095A060-0x0095A460
		public void ImageOn(GameObject obj) {} // 0x00959D40-0x00959EA0
		public void InputTextNew(GameObject obj) {} // 0x0095A460-0x0095A630
		protected void FocusOn(GameObject obj) {} // 0x00959EA0-0x00959F80
		protected void FocusOut(GameObject obj) {} // 0x0095A630-0x0095A710
		protected void SelectOn(GameObject obj) {} // 0x00959F80-0x0095A060
		protected virtual void SelectOut(GameObject obj) {} // 0x0095A710-0x0095A7F0
		protected virtual void InitialSet(string text) {} // 0x0095A7F0-0x0095AAB0
		protected virtual void SetEnterText() {} // 0x0095AAB0-0x0095AD40
		protected virtual void GetEnterText() {} // 0x0095AD40-0x0095AE80
		protected virtual void CursorSet() {} // 0x0095AE80-0x0095B010
		protected virtual void CursorSet(int SetNum) {} // 0x0095B010-0x0095B160
		protected override bool _doUp() => default; // 0x0095B160-0x0095B400
		protected override bool _doDown() => default; // 0x0095B400-0x0095B6B0
		protected override bool _doLeft() => default; // 0x0095B6B0-0x0095B920
		protected override bool _doRight() => default; // 0x0095B920-0x0095BB90
		protected override bool _doShiftLeft() => default; // 0x0095BB90-0x0095BD20
		protected override bool _doShiftRight() => default; // 0x0095BD20-0x0095BEF0
		protected virtual bool doSpecial() => default; // 0x0095BEF0-0x0095C090
		protected override bool _doTouchEnded(Vector3 touch) => default; // 0x0095C090-0x0095CBF0
		protected override bool _doTouchAnimation(Vector2 touch, TouchPhase phase) => default; // 0x0095CBF0-0x0095DD90
		protected override bool _doEnter(int x, int y, bool bTouch = false /* Metadata: 0x0061343B */) => default; // 0x0095DD90-0x0095DF40
		protected virtual bool _doTempEnter(int x, int y) => default; // 0x0095EEA0-0x0095EF90
		protected override bool _doEntering(int x, int y) => default; // 0x0095F3B0-0x0095F490
		protected override bool _doDiscontinue() => default; // 0x0095F490-0x0095F510
		protected override bool _doCancel() => default; // 0x0095F510-0x0095F710
		protected virtual bool _doSelectDelete(bool blongPress) => default; // 0x0095F710-0x0095F7B0
		protected override bool _doDelete() => default; // 0x0095F7B0-0x0095F950
		protected override bool _doDecide() => default; // 0x0095F950-0x0095FB20
		protected virtual void _doFinish() {} // 0x0095FB20-0x0095FBD0
		protected virtual void CantFinish() {} // 0x0095FBD0-0x0095FD00
		protected void doSwitchINSorOVR() {} // 0x0095DF40-0x0095E250
		protected override bool _doFormChange() => default; // 0x0095FD00-0x0095FFC0
		protected void doVoiced(int x, int y) {} // 0x0095EA60-0x0095EC80
		protected void doTempVoiced(int x, int y) {} // 0x0095EF90-0x0095F1A0
		protected void doSemiVoiced(int x, int y) {} // 0x0095EC80-0x0095EEA0
		protected void doTempSemiVoiced(int x, int y) {} // 0x0095F1A0-0x0095F3B0
		protected string AllPaletteCheck(string message, LanguagePalette[,] palette, int i, int j) => default; // 0x0095FFC0-0x00960830
		protected string VoicedPaletteCheck(string message, LanguagePalette[,] palette, int i, int j) => default; // 0x00960830-0x00960C10
		protected string SemiVoicedPaletteCheck(string message, LanguagePalette[,] palette, int i, int j) => default; // 0x00960C10-0x00960FF0
		protected override bool _doPaletteChange() => default; // 0x00960FF0-0x00961120
		protected virtual void _doInputWord(int X, int Y, bool bSound = true /* Metadata: 0x0061343C */) {} // 0x00961120-0x009613E0
		protected virtual void _doTempInputWord(int X, int Y) {} // 0x009613E0-0x00961670
		protected virtual void doPack() {} // 0x00961670-0x009618C0
		protected virtual void doPush(int start) {} // 0x009618C0-0x00961B50
		protected void doPaletteChangeHira() {} // 0x0095E250-0x0095E500
		protected void doPaletteChangeKata() {} // 0x0095E500-0x0095E7B0
		protected void doPaletteChangeKigou() {} // 0x0095E7B0-0x0095EA60
		protected virtual void PaletteMake(LanguagePalette[,] palette) {} // 0x00961B50-0x009620D0
		protected virtual bool SkipAnimation() => default; // 0x009620D0-0x009620E0
		// [IteratorStateMachine] // 0x0064D4A0-0x0064D510
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x009620E0-0x00962160
	}

	public class StateInit : FSMState<UINaming, States> // TypeDefIndex: 7133
	{
		// Properties
		public override States StateID { get => default; } // 0x00DD9440-0x00DD9450 

		// Constructors
		public StateInit() {} // 0x00DD9480-0x00DD94D0

		// Methods
		public override void Enter() {} // 0x00DD9450-0x00DD9460
		public override void Execute() {} // 0x00DD9460-0x00DD9470
		public override void Exit() {} // 0x00DD9470-0x00DD9480
	}

	public class StateStart : FSMState<UINaming, States> // TypeDefIndex: 7134
	{
		// Properties
		public override States StateID { get => default; } // 0x00DD94D0-0x00DD94E0 

		// Constructors
		public StateStart() {} // 0x00DD9600-0x00DD9650

		// Methods
		public override void Enter() {} // 0x00DD94E0-0x00DD95D0
		public override void Execute() {} // 0x00DD95D0-0x00DD95F0
		public override void Exit() {} // 0x00DD95F0-0x00DD9600
	}

	public class StateFinish : FSMState<UINaming, States> // TypeDefIndex: 7135
	{
		// Properties
		public override States StateID { get => default; } // 0x00DD93A0-0x00DD93B0 

		// Constructors
		public StateFinish() {} // 0x00DD93F0-0x00DD9440

		// Methods
		public override void Enter() {} // 0x00DD93B0-0x00DD93D0
		public override void Execute() {} // 0x00DD93D0-0x00DD93E0
		public override void Exit() {} // 0x00DD93E0-0x00DD93F0
	}

	public class StateEnd : FSMState<UINaming, States> // TypeDefIndex: 7136
	{
		// Properties
		public override States StateID { get => default; } // 0x00DD9310-0x00DD9320 

		// Constructors
		public StateEnd() {} // 0x00DD9350-0x00DD93A0

		// Methods
		public override void Enter() {} // 0x00DD9320-0x00DD9330
		public override void Execute() {} // 0x00DD9330-0x00DD9340
		public override void Exit() {} // 0x00DD9340-0x00DD9350
	}

	public class StateDecide : FSMState<UINaming, States> // TypeDefIndex: 7137
	{
		// Properties
		public override States StateID { get => default; } // 0x00DD9230-0x00DD9240 

		// Constructors
		public StateDecide() {} // 0x00DD92C0-0x00DD9310

		// Methods
		public override void Enter() {} // 0x00DD9240-0x00DD9250
		public override void Execute() {} // 0x00DD9250-0x00DD92B0
		public override void Exit() {} // 0x00DD92B0-0x00DD92C0
	}

	public class StateCancel : FSMState<UINaming, States> // TypeDefIndex: 7138
	{
		// Properties
		public override States StateID { get => default; } // 0x00DD9150-0x00DD9160 

		// Constructors
		public StateCancel() {} // 0x00DD91E0-0x00DD9230

		// Methods
		public override void Enter() {} // 0x00DD9160-0x00DD9170
		public override void Execute() {} // 0x00DD9170-0x00DD91D0
		public override void Exit() {} // 0x00DD91D0-0x00DD91E0
	}

	// Constructors
	public UINaming() {} // 0x00958FD0-0x00959030

	// Methods
	public static UINaming Create() => default; // 0x00958780-0x00958880
	public virtual void Construct() {} // 0x00958880-0x00958B20
	public virtual void Init(UINamingControl.NamingParam namingParam) {} // 0x00958BC0-0x00958C10
	// [IteratorStateMachine] // 0x0062A3C0-0x0062A430
	public virtual IEnumerator MainFlow(Action<bool> resultCb, Action<string> TextCb, Action<EnterTextWindow.ActionType> actTypeCb) => default; // 0x00958C10-0x00958CA0
	public virtual List<string> GetNameList() => default; // 0x00958CD0-0x00958CE0
	public virtual string GetInitText() => default; // 0x00958CE0-0x00958CF0
	private void Update() {} // 0x00958CF0-0x00958D50
	protected virtual void _cbFromNamingWindow(EnterTextWindow.ActionType act) {} // 0x00958D50-0x00958E30
	// [IteratorStateMachine] // 0x0062A430-0x0062A4A0
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00958E30-0x00958EB0
	public virtual void DoOpenEnter() {} // 0x00958EE0-0x00958F70
	public virtual void DoCloseEnter() {} // 0x00958F70-0x00958FD0
}

