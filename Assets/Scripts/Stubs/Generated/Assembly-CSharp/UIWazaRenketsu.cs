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

public class UIWazaRenketsu : UIManagerBase // TypeDefIndex: 7878
{
	// Fields
	private FlowPlay flowInstance_; // 0x20
	public FiniteStateMachine<UIWazaRenketsu, States> FSM; // 0x28
	private bool bCancel_; // 0x30
	private GameObject mainObj_; // 0x38
	private WazaWindow wazaWindow_; // 0x40
	private RenketuModeWazaWindow renketuModeWazaWindow_; // 0x48
	private RenketuMenuWindow renketuMenuWindow_; // 0x50
	private int nAnimCount_; // 0x58
	private ViewState viewState_; // 0x5C

	// Nested types
	public enum States // TypeDefIndex: 7879
	{
		Init = 0,
		Start = 1,
		MenuSelect = 2,
		MenuDecide = 3,
		MenuCancel = 4,
		Finish = 5,
		End = 6
	}

	private class WazaWindow // TypeDefIndex: 7880
	{
		// Constructors
		public WazaWindow() {} // 0x00D58880-0x00D58890

		// Methods
		public void Init(GameObject objRoot, int presetIndex, UIWazaRenketsu manager) {} // 0x00D58870-0x00D58880
	}

	private class RenketuModeWazaWindow // TypeDefIndex: 7881
	{
		// Constructors
		public RenketuModeWazaWindow() {} // 0x00D58490-0x00D584A0

		// Methods
		public void Init(GameObject objRoot, int presetIndex, UIWazaRenketsu manager) {} // 0x00D58480-0x00D58490
	}

	private class RenketuMenuWindow // TypeDefIndex: 7882
	{
		// Fields
		private MenuType type_; // 0x10
		private GameObject obj_; // 0x18
		private UIWazaRenketsu manager_; // 0x20
		private GameObject renketu_renketu; // 0x28
		private GameObject renketu_bunkai; // 0x30
		private GameObject renketu_keyAllocation; // 0x38
		private bool bDecide; // 0x40
		private int nAnimCount_; // 0x44
		private ViewState viewState_; // 0x48

		// Nested types
		private enum MenuType // TypeDefIndex: 7883
		{
			Renketu = 0,
			Bunkai = 1,
			KeyChange = 2,
			Max = 3
		}

		public enum ViewState // TypeDefIndex: 7884
		{
			NONE = 0,
			OPENED = 1,
			CLOSED = 2
		}

		// Constructors
		public RenketuMenuWindow() {} // 0x00D559B0-0x00D559C0

		// Methods
		public void Init(GameObject objRoot, int presetIndex, UIWazaRenketsu manager) {} // 0x00D55CC0-0x00D55DC0
		public void SetActive(bool b) {} // 0x00D566B0-0x00D566C0
		public void Update() {} // 0x00D566C0-0x00D56750
		private void FaceUpdate(Transform transform, bool selectItem) {} // 0x00D56870-0x00D569E0
		private void DecideAnim() {} // 0x00D569E0-0x00D56E60
		private void _doInput() {} // 0x00D56750-0x00D56870
		private bool _doLeft() => default; // 0x00D57190-0x00D571C0
		private bool _doRight() => default; // 0x00D57160-0x00D57190
		private bool _doDecide() => default; // 0x00D571C0-0x00D571E0
		private bool _doCancel() => default; // 0x00D571E0-0x00D571F0
		private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00D571F0-0x00D57220
		// [IteratorStateMachine] // 0x006525F0-0x00652660
		public IEnumerator RenketuModeDecide(Action cb) => default; // 0x00D56E60-0x00D56EE0
		// [IteratorStateMachine] // 0x00652660-0x006526D0
		public IEnumerator RenketuModeNotDecide(Action cb) => default; // 0x00D57060-0x00D570E0
		// [IteratorStateMachine] // 0x006526D0-0x00652740
		public IEnumerator BunkaiModeDecide(Action cb) => default; // 0x00D56FE0-0x00D57060
		// [IteratorStateMachine] // 0x00652740-0x006527B0
		public IEnumerator BunkaiModeNotDecide(Action cb) => default; // 0x00D56EE0-0x00D56F60
		// [IteratorStateMachine] // 0x006527B0-0x00652820
		public IEnumerator Key_AllocationModeDecide(Action cb) => default; // 0x00D570E0-0x00D57160
		// [IteratorStateMachine] // 0x00652820-0x00652890
		public IEnumerator Key_AllocationModeNotDecide(Action cb) => default; // 0x00D56F60-0x00D56FE0
	}

	public enum ViewState // TypeDefIndex: 7891
	{
		NONE = 0,
		OPENED = 1,
		CLOSED = 2
	}

	public class StateInit : FSMState<UIWazaRenketsu, States> // TypeDefIndex: 7892
	{
		// Properties
		public override States StateID { get => default; } // 0x00D58520-0x00D58530 

		// Constructors
		public StateInit() {} // 0x00D58560-0x00D585B0

		// Methods
		public override void Enter() {} // 0x00D58530-0x00D58540
		public override void Execute() {} // 0x00D58540-0x00D58550
		public override void Exit() {} // 0x00D58550-0x00D58560
	}

	public class StateStart : FSMState<UIWazaRenketsu, States> // TypeDefIndex: 7893
	{
		// Properties
		public override States StateID { get => default; } // 0x00D586F0-0x00D58700 

		// Constructors
		public StateStart() {} // 0x00D559C0-0x00D55A10

		// Methods
		public override void Enter() {} // 0x00D58700-0x00D587F0
		public override void Execute() {} // 0x00D587F0-0x00D58800
		public override void Exit() {} // 0x00D58800-0x00D58810
	}

	public class StateFinish : FSMState<UIWazaRenketsu, States> // TypeDefIndex: 7894
	{
		// Properties
		public override States StateID { get => default; } // 0x00D584E0-0x00D584F0 

		// Constructors
		public StateFinish() {} // 0x00D55A10-0x00D55A60

		// Methods
		public override void Enter() {} // 0x00D584F0-0x00D58500
		public override void Execute() {} // 0x00D58500-0x00D58510
		public override void Exit() {} // 0x00D58510-0x00D58520
	}

	public class StateEnd : FSMState<UIWazaRenketsu, States> // TypeDefIndex: 7895
	{
		// Properties
		public override States StateID { get => default; } // 0x00D584A0-0x00D584B0 

		// Constructors
		public StateEnd() {} // 0x00D55A60-0x00D55AB0

		// Methods
		public override void Enter() {} // 0x00D584B0-0x00D584C0
		public override void Execute() {} // 0x00D584C0-0x00D584D0
		public override void Exit() {} // 0x00D584D0-0x00D584E0
	}

	public class StateMenuSelect : FSMState<UIWazaRenketsu, States> // TypeDefIndex: 7896
	{
		// Properties
		public override States StateID { get => default; } // 0x00D58630-0x00D58640 

		// Constructors
		public StateMenuSelect() {} // 0x00D55AB0-0x00D55B00

		// Methods
		public override void Enter() {} // 0x00D58640-0x00D58650
		public override void Execute() {} // 0x00D58650-0x00D586E0
		public override void Exit() {} // 0x00D586E0-0x00D586F0
	}

	public class StateMenuDecide : FSMState<UIWazaRenketsu, States> // TypeDefIndex: 7897
	{
		// Properties
		public override States StateID { get => default; } // 0x00D585F0-0x00D58600 

		// Constructors
		public StateMenuDecide() {} // 0x00D55B00-0x00D55B50

		// Methods
		public override void Enter() {} // 0x00D58600-0x00D58610
		public override void Execute() {} // 0x00D58610-0x00D58620
		public override void Exit() {} // 0x00D58620-0x00D58630
	}

	public class StateMenuCancel : FSMState<UIWazaRenketsu, States> // TypeDefIndex: 7898
	{
		// Properties
		public override States StateID { get => default; } // 0x00D585B0-0x00D585C0 

		// Constructors
		public StateMenuCancel() {} // 0x00D55B50-0x00D55BA0

		// Methods
		public override void Enter() {} // 0x00D585C0-0x00D585D0
		public override void Execute() {} // 0x00D585D0-0x00D585E0
		public override void Exit() {} // 0x00D585E0-0x00D585F0
	}

	// Constructors
	public UIWazaRenketsu() {} // 0x00D56060-0x00D56070

	// Methods
	public static UIWazaRenketsu Create(GameObject mainObj) => default; // 0x00D55630-0x00D556F0
	public void Construct() {} // 0x00D556F0-0x00D559B0
	public void Init(FlowPlay instance, GameObject mainObj) {} // 0x00D55BA0-0x00D55CC0
	// [IteratorStateMachine] // 0x0062EEA0-0x0062EF10
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00D55DC0-0x00D55E40
	private void Update() {} // 0x00D55E70-0x00D55ED0
	private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00D55ED0-0x00D55F00
	// [IteratorStateMachine] // 0x0062EF10-0x0062EF80
	public IEnumerator OpenRenketsuMenuWindow(Action cb) => default; // 0x00D55F00-0x00D55F80
	// [IteratorStateMachine] // 0x0062EF80-0x0062EFF0
	public IEnumerator CloseRenketsuMenuWindow(Action cb) => default; // 0x00D55FB0-0x00D56030
}

