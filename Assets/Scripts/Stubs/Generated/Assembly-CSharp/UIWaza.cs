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

public class UIWaza : UIManagerBase // TypeDefIndex: 7732
{
	// Fields
	private FlowPlay flowInstance_; // 0x20
	public FiniteStateMachine<UIWaza, States> FSM; // 0x28
	private bool bCancel_; // 0x30
	public MenuType menuType_; // 0x34
	private CommonScreen commonScreen_; // 0x38
	private PokemonSelectWindow pokemonSelectWindow_; // 0x40
	private WazaWindow wazaWindow_; // 0x48
	private RenketuModeWazaWindow renketuModeWazaWindow_; // 0x50
	private RenketuMenuWindow renketuMenuWindow_; // 0x58
	private int nAnimCount_; // 0x60
	private ViewState viewState_; // 0x64

	// Nested types
	public enum MenuType // TypeDefIndex: 7733
	{
		None = 0,
		Renketu = 1,
		Forget = 2,
		Max = 3
	}

	public enum States // TypeDefIndex: 7734
	{
		Init = 0,
		Start = 1,
		ListSelect = 2,
		ListDecide = 3,
		ListCancel = 4,
		Finish = 5,
		End = 6,
		MenuSelect = 7
	}

	private class PokemonSelectWindow : PokemonWarehouseListWindow // TypeDefIndex: 7735
	{
		// Fields
		private UIWaza manager_; // 0xC8

		// Nested types
		public class UILocalSelectItem : PokemonWarehouseListWindow.UIPokemonWarehouseSelectItem // TypeDefIndex: 7736
		{
			// Fields
			private int organizationNo_; // 0x30

			// Properties
			public int OrganizationNo { get => default; set {} } // 0x00DC44D0-0x00DC44E0 0x00DC44C0-0x00DC44D0

			// Constructors
			public UILocalSelectItem() {} // 0x00DC44B0-0x00DC44C0

			// Methods
			public override bool IsFavor() => default; // 0x00DC44E0-0x00DC44F0
			public override int GetOrganizationNo() => default; // 0x00DC44F0-0x00DC4500
		}

		// Constructors
		public PokemonSelectWindow() {} // 0x00DC30A0-0x00DC30B0

		// Methods
		public void Init(GameObject objRoot, int presetIndex, UIWaza manager) {} // 0x00DC3590-0x00DC3780
		public void _cbFromListWindow(ActionType act) {} // 0x00DC4180-0x00DC4240
	}

	private class WazaWindow // TypeDefIndex: 7739
	{
		// Constructors
		public WazaWindow() {} // 0x00DC69F0-0x00DC6A00

		// Methods
		public void Init(GameObject objRoot, int presetIndex, UIWaza manager) {} // 0x00DC69E0-0x00DC69F0
	}

	private class RenketuModeWazaWindow // TypeDefIndex: 7740
	{
		// Constructors
		public RenketuModeWazaWindow() {} // 0x00DC63F0-0x00DC6400

		// Methods
		public void Init(GameObject objRoot, int presetIndex, UIWaza manager) {} // 0x00DC63E0-0x00DC63F0
	}

	private class RenketuMenuWindow // TypeDefIndex: 7741
	{
		// Fields
		private MenuType type_; // 0x10
		private GameObject obj_; // 0x18
		private UIWaza manager_; // 0x20
		private GameObject renketu_renketu; // 0x28
		private GameObject renketu_bunkai; // 0x30
		private GameObject renketu_keyAllocation; // 0x38
		private bool bDecide; // 0x40
		private int nAnimCount_; // 0x44
		private ViewState viewState_; // 0x48

		// Nested types
		private enum MenuType // TypeDefIndex: 7742
		{
			Renketu = 0,
			Bunkai = 1,
			KeyChange = 2,
			Max = 3
		}

		public enum ViewState // TypeDefIndex: 7743
		{
			NONE = 0,
			OPENED = 1,
			CLOSED = 2
		}

		// Constructors
		public RenketuMenuWindow() {} // 0x00DC30B0-0x00DC30C0

		// Methods
		public void Init(GameObject objRoot, int presetIndex, UIWaza manager) {} // 0x00DC3780-0x00DC3880
		public void SetActive(bool b) {} // 0x00DC4500-0x00DC4510
		public void Update() {} // 0x00DC4510-0x00DC45A0
		private void FaceUpdate(Transform transform, bool selectItem) {} // 0x00DC4690-0x00DC4800
		private void DecideAnim() {} // 0x00DC4800-0x00DC4C80
		private void _doInput() {} // 0x00DC45A0-0x00DC4690
		private bool _doLeft() => default; // 0x00DC5050-0x00DC5120
		private bool _doRight() => default; // 0x00DC4F80-0x00DC5050
		private bool _doDecide() => default; // 0x00DC5120-0x00DC5140
		private bool _doCancel() => default; // 0x00DC5140-0x00DC5150
		private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00DC5150-0x00DC5180
		// [IteratorStateMachine] // 0x00651500-0x00651570
		public IEnumerator RenketuModeDecide(Action cb) => default; // 0x00DC4C80-0x00DC4D00
		// [IteratorStateMachine] // 0x00651570-0x006515E0
		public IEnumerator RenketuModeNotDecide(Action cb) => default; // 0x00DC4E80-0x00DC4F00
		// [IteratorStateMachine] // 0x006515E0-0x00651650
		public IEnumerator BunkaiModeDecide(Action cb) => default; // 0x00DC4E00-0x00DC4E80
		// [IteratorStateMachine] // 0x00651650-0x006516C0
		public IEnumerator BunkaiModeNotDecide(Action cb) => default; // 0x00DC4D00-0x00DC4D80
		// [IteratorStateMachine] // 0x006516C0-0x00651730
		public IEnumerator Key_AllocationModeDecide(Action cb) => default; // 0x00DC4F00-0x00DC4F80
		// [IteratorStateMachine] // 0x00651730-0x006517A0
		public IEnumerator Key_AllocationModeNotDecide(Action cb) => default; // 0x00DC4D80-0x00DC4E00
	}

	public enum ViewState // TypeDefIndex: 7750
	{
		NONE = 0,
		OPENED = 1,
		CLOSED = 2
	}

	public class StateInit : FSMState<UIWaza, States> // TypeDefIndex: 7751
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC6480-0x00DC6490 

		// Constructors
		public StateInit() {} // 0x00DC64C0-0x00DC6510

		// Methods
		public override void Enter() {} // 0x00DC6490-0x00DC64A0
		public override void Execute() {} // 0x00DC64A0-0x00DC64B0
		public override void Exit() {} // 0x00DC64B0-0x00DC64C0
	}

	public class StateStart : FSMState<UIWaza, States> // TypeDefIndex: 7752
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC6880-0x00DC6890 

		// Constructors
		public StateStart() {} // 0x00DC30C0-0x00DC3110

		// Methods
		public override void Enter() {} // 0x00DC6890-0x00DC6960
		public override void Execute() {} // 0x00DC6960-0x00DC6970
		public override void Exit() {} // 0x00DC6970-0x00DC6980
	}

	public class StateFinish : FSMState<UIWaza, States> // TypeDefIndex: 7753
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC6440-0x00DC6450 

		// Constructors
		public StateFinish() {} // 0x00DC3200-0x00DC3250

		// Methods
		public override void Enter() {} // 0x00DC6450-0x00DC6460
		public override void Execute() {} // 0x00DC6460-0x00DC6470
		public override void Exit() {} // 0x00DC6470-0x00DC6480
	}

	public class StateEnd : FSMState<UIWaza, States> // TypeDefIndex: 7754
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC6400-0x00DC6410 

		// Constructors
		public StateEnd() {} // 0x00DC3250-0x00DC32A0

		// Methods
		public override void Enter() {} // 0x00DC6410-0x00DC6420
		public override void Execute() {} // 0x00DC6420-0x00DC6430
		public override void Exit() {} // 0x00DC6430-0x00DC6440
	}

	public class StateListSelect : FSMState<UIWaza, States> // TypeDefIndex: 7755
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC6590-0x00DC65A0 

		// Constructors
		public StateListSelect() {} // 0x00DC3110-0x00DC3160

		// Methods
		public override void Enter() {} // 0x00DC65A0-0x00DC65C0
		public override void Execute() {} // 0x00DC65C0-0x00DC65E0
		public override void Exit() {} // 0x00DC65E0-0x00DC6700
	}

	public class StateMenuSelect : FSMState<UIWaza, States> // TypeDefIndex: 7756
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC67C0-0x00DC67D0 

		// Constructors
		public StateMenuSelect() {} // 0x00DC32A0-0x00DC32F0

		// Methods
		public override void Enter() {} // 0x00DC67D0-0x00DC67E0
		public override void Execute() {} // 0x00DC67E0-0x00DC6870
		public override void Exit() {} // 0x00DC6870-0x00DC6880
	}

	public class StateListDecide : FSMState<UIWaza, States> // TypeDefIndex: 7757
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC6550-0x00DC6560 

		// Constructors
		public StateListDecide() {} // 0x00DC3160-0x00DC31B0

		// Methods
		public override void Enter() {} // 0x00DC6560-0x00DC6570
		public override void Execute() {} // 0x00DC6570-0x00DC6580
		public override void Exit() {} // 0x00DC6580-0x00DC6590
	}

	public class StateListCancel : FSMState<UIWaza, States> // TypeDefIndex: 7758
	{
		// Properties
		public override States StateID { get => default; } // 0x00DC6510-0x00DC6520 

		// Constructors
		public StateListCancel() {} // 0x00DC31B0-0x00DC3200

		// Methods
		public override void Enter() {} // 0x00DC6520-0x00DC6530
		public override void Execute() {} // 0x00DC6530-0x00DC6540
		public override void Exit() {} // 0x00DC6540-0x00DC6550
	}

	// Constructors
	public UIWaza() {} // 0x00DC3B20-0x00DC3B30

	// Methods
	public static UIWaza Create() => default; // 0x00DC2C30-0x00DC2D30
	public void Construct() {} // 0x00DC2D30-0x00DC30A0
	public void Init(FlowPlay instance, MenuType type) {} // 0x00DC32F0-0x00DC3590
	// [IteratorStateMachine] // 0x0062E4C0-0x0062E530
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00DC3880-0x00DC3900
	private void Update() {} // 0x00DC3930-0x00DC3990
	private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00DC3990-0x00DC39C0
	// [IteratorStateMachine] // 0x0062E530-0x0062E5A0
	public IEnumerator OpenPokemonSelectWindow(Action cb) => default; // 0x00DC39C0-0x00DC3A40
	// [IteratorStateMachine] // 0x0062E5A0-0x0062E610
	public IEnumerator ClosePokemonSelectWindow(Action cb) => default; // 0x00DC3A70-0x00DC3AF0
}

