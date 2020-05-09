/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SpecialAnim;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIPelipper : UIManagerBase // TypeDefIndex: 7324
{
	// Fields
	private PegasusTime.POSIX32 lastInternetAccessTime_; // 0x1C
	public FiniteStateMachine<UIPelipper, States> FSM; // 0x20
	public bool bCancel_; // 0x28
	private GameObject mainObj_; // 0x30
	private FlowPelipper flowInstance_; // 0x38
	private LoadingScreen loadingScreen_; // 0x40
	private CommonScreen commonScreen_; // 0x48
	private GameObject netListObj; // 0x50
	public PerformanceMode performanceMode_; // 0x58
	private ThanksMode thanksMode_; // 0x60
	private BillboardWindow_MyRequest billboardWindowMyRequest_; // 0x68
	private BillboardWindow_InterNet billboardWindowInterNet_; // 0x70
	private ButtonSelect buttonSelect_; // 0x78
	private RescueRequestWindow requestMainWindow_; // 0x80
	private ReportModeWindow reportModeWindow_; // 0x88

	// Properties
	public FlowPelipper FlowInstance_ { get => default; } // 0x00C7F480-0x00C7F490 

	// Nested types
	public enum States // TypeDefIndex: 7325
	{
		None = 0,
		RequestCreate_SelectThanks = 1,
		RequestCreate_Pay = 2,
		RequestCreate_SendMail = 3,
		RequestCreate_Billboard = 4,
		RequestCreate_Billboard_Delete = 5,
		Request_Billboard_Delete = 6,
		ReportMode_Incoming = 7,
		RequestQuest_Check = 8,
		OtherRequestQuest_Check = 9,
		RequestQuest_Popup = 10,
		InputRevivePassWord = 11,
		InputRescuePassWord = 12,
		ConnectInternet_SendMail = 13,
		ReportMailList = 14,
		UnclaimedMailList = 15,
		MailDelete = 16,
		InternetBillboard = 17,
		ConnectInternet_GetList = 18,
		ConnectInternet_ReGetList = 19,
		ConnectInternet_Achievement = 20,
		ConnectInternet_Confirm = 21,
		RankUpMode = 22,
		InterNetConfirmTop = 23,
		NotRescued = 24,
		CreatePassword = 25,
		MailClose = 26,
		InternetConnect_Failed = 27,
		ConnectInternet_Delete = 28,
		ThanksMode = 29,
		ConnectInternet_GetList_ForFriend = 30,
		ConnectInternet_GetList_ForUserId = 31,
		CloseInternetBillboard = 32,
		InputUserId = 33,
		ConnectInternet_GetList_Return = 34,
		End = 35
	}

	public class ThanksMode : UIWindowBase // TypeDefIndex: 7326
	{
		// Fields
		private string[] actionName_; // 0x30
		private Anim<ViewState> anim; // 0x38
		private GameObject unclaimedObj_; // 0x40
		private UIPelipper manager_; // 0x48
		private GameObject root_; // 0x50
		private GameObject mailBg_; // 0x58
		private bool isPopuped; // 0x60
		private bool isMoving; // 0x61
		private GameObject popupObj; // 0x68

		// Nested types
		public enum ViewState // TypeDefIndex: 7327
		{
			NONE = 0,
			INSERT = 1,
			MOVE = 2,
			NG = 3,
			RESET = 4
		}

		// Constructors
		public ThanksMode() {} // 0x00C806C0-0x00C80930

		// Methods
		public void NGAnimation() {} // 0x00C82F80-0x00C83000
		public void PlayAnim(ViewState state, Action cb = null) {} // 0x00C821F0-0x00C822F0
		public bool IsViewState(ViewState viewState) => default; // 0x00C918B0-0x00C91920
		public void SetActiveMailBg(bool b) {} // 0x00C82F70-0x00C82F80
		public void Init(GameObject root, UIPelipper manager) {} // 0x00C904A0-0x00C912A0
		protected override void _doUpdate() {} // 0x00C91920-0x00C91930
		private void input() {} // 0x00C91930-0x00C919E0
		public void ResetViewState() {} // 0x00C912A0-0x00C912B0
	}

	public class BillboardWindow : BasicListWindow // TypeDefIndex: 7328
	{
		// Fields
		protected List<IFriendRescueTicket> questList_; // 0x88

		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7329
		{
			// Fields
			private IFriendRescueTicket item_; // 0x18
			public bool bDiscovery_; // 0x20
			public PegasusTime.RemainTime remainTime_; // 0x28

			// Properties
			public IFriendRescueTicket Item { get => default; set {} } // 0x00C83B60-0x00C83B70 0x00C83B50-0x00C83B60

			// Constructors
			public UILocalSelectItem() {} // 0x00C83B70-0x00C83B80
		}

		public class UILocalSelector : UISelectorBase // TypeDefIndex: 7330
		{
			// Constructors
			public UILocalSelector() {} // 0x00C849D0-0x00C84A40

			// Methods
			protected override void SetupFace() {} // 0x00C83B80-0x00C848C0
			private bool CheckList(uint userId) => default; // 0x00C848C0-0x00C849D0
		}

		// Constructors
		public BillboardWindow() {} // 0x00C83B40-0x00C83B50
	}

	public class BillboardWindow_MyRequest : BillboardWindow // TypeDefIndex: 7331
	{
		// Fields
		private DisplayType type_; // 0x90
		private UIPelipper manager_; // 0x98
		private GameObject obj_; // 0xA0

		// Nested types
		public enum DisplayType // TypeDefIndex: 7332
		{
			NORMAL = 0,
			DELETE_CONFIRM = 1,
			DELETE = 2
		}

		// Constructors
		public BillboardWindow_MyRequest() {} // 0x00C806A0-0x00C806B0

		// Methods
		public void Init(GameObject obj, UIPelipper manager, DisplayType type = DisplayType.NORMAL /* Metadata: 0x006136DA */) {} // 0x00C872F0-0x00C87680
		public void Uninit() {} // 0x00C87680-0x00C87690
		public void input() {} // 0x00C87690-0x00C876A0
	}

	public class BillboardWindow_InterNet : BillboardWindow // TypeDefIndex: 7334
	{
		// Fields
		private GameObject subWindowObj_; // 0x90
		private UIControlTMPSetter countTMP; // 0x98
		private UIControlTMPInitializer capacityTMP; // 0xA0
		private UIPelipper manager_; // 0xA8
		private UIControlTMP pageTmp_; // 0xB0
		private GameObject leftButton_; // 0xB8
		private GameObject rightButton_; // 0xC0
		private GameObject netList_; // 0xC8
		private GameObject menuSet_; // 0xD0
		private bool arrivalFloor_; // 0xD8
		private bool bOld; // 0xD9

		// Properties
		public bool ArrivalFloor { get => default; } // 0x00C84A70-0x00C84A80 

		// Constructors
		public BillboardWindow_InterNet() {} // 0x00C806B0-0x00C806C0

		// Methods
		public void SetSubWindowCount() {} // 0x00C815B0-0x00C81830
		// [IteratorStateMachine] // 0x0064E990-0x0064EA00
		public IEnumerator PlayOver() => default; // 0x00C82700-0x00C82770
		public void Init(GameObject obj, UIPelipper manager, Action cb) {} // 0x00C84A80-0x00C84CD0
		// [IteratorStateMachine] // 0x0064EA00-0x0064EA70
		private IEnumerator TicketLowestMessage(Action cb) => default; // 0x00C84CE0-0x00C84D60
		private void ListSet(GameObject obj, Action cb) {} // 0x00C84D60-0x00C854E0
		protected override bool _doDecide() => default; // 0x00C85510-0x00C856C0
		protected override bool _doCancel() => default; // 0x00C856C0-0x00C85770
		protected override void _changePage() {} // 0x00C85770-0x00C85870
		protected override bool _doLeft() => default; // 0x00C85870-0x00C858E0
		protected override bool _doRight() => default; // 0x00C858E0-0x00C85950
		protected override bool _onYButton() => default; // 0x00C85950-0x00C85C90
		// [IteratorStateMachine] // 0x0064EA70-0x0064EAE0
		private IEnumerator NotAccessMessage() => default; // 0x00C862C0-0x00C86330
		protected override void _changeFocus() {} // 0x00C86360-0x00C86370
		public void CloseList() {} // 0x00C86370-0x00C86400
		public void OpenList() {} // 0x00C86400-0x00C86490
		public override void Update() {} // 0x00C86490-0x00C864D0
		protected override bool _onXButton() => default; // 0x00C864D0-0x00C86730
		private void SetFavo() {} // 0x00C86730-0x00C86880
		protected override void _doUpdate() {} // 0x00C86880-0x00C86990
	}

	private class ButtonSelect : BasicMenuWindow // TypeDefIndex: 7340
	{
		// Fields
		private GameObject[] buttons_; // 0x48
		private UIPelipper manager_; // 0x50
		private GameObject root_; // 0x58

		// Constructors
		public ButtonSelect() {} // 0x00C80930-0x00C80940

		// Methods
		protected override bool _doLeft() => default; // 0x00C87930-0x00C87940
		protected override bool _doRight() => default; // 0x00C87940-0x00C87950
		public void Init(GameObject root, string[] sMenuTag, UIPelipper manager, int defaultIndex = 0 /* Metadata: 0x006136EA */) {} // 0x00C85C90-0x00C862C0
		public void FaceVisibleOff() {} // 0x00C87950-0x00C879D0
		// [IteratorStateMachine] // 0x0064EB00-0x0064EB70
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00C879D0-0x00C87A50
		public void OpenBg() {} // 0x00C87A80-0x00C87B90
		// [IteratorStateMachine] // 0x0064EB70-0x0064EBE0
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00C87B90-0x00C87C10
		public void CloseBg() {} // 0x00C87C40-0x00C87D50
		private void _cb(ActionType act) {} // 0x00C87D50-0x00C88290
		protected override bool _doBButton() => default; // 0x00C88290-0x00C882C0
		protected override bool _doYButton() => default; // 0x00C883D0-0x00C88400
		private void CloseButton() {} // 0x00C882C0-0x00C883D0
	}

	public class StateRequestCreate_SelectThanks : FSMState<UIPelipper, States> // TypeDefIndex: 7346
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8ED90-0x00C8EDA0 

		// Constructors
		public StateRequestCreate_SelectThanks() {} // 0x00C80940-0x00C80990

		// Methods
		public override void Enter() {} // 0x00C8EDA0-0x00C8F000
		public override void Execute() {} // 0x00C8F000-0x00C8F020
	}

	public class StateRequestQuest_Check : FSMState<UIPelipper, States> // TypeDefIndex: 7347
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8F4C0-0x00C8F4D0 

		// Constructors
		public StateRequestQuest_Check() {} // 0x00C80A30-0x00C80A80

		// Methods
		public override void Enter() {} // 0x00C8F4D0-0x00C8F6D0
		public override void Execute() {} // 0x00C8F6D0-0x00C8F6F0
	}

	public class StateOtherRequestQuest_Check : FSMState<UIPelipper, States> // TypeDefIndex: 7348
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8E450-0x00C8E460 

		// Constructors
		public StateOtherRequestQuest_Check() {} // 0x00C80A80-0x00C80AD0

		// Methods
		public override void Enter() {} // 0x00C8E460-0x00C8E5B0
		public override void Execute() {} // 0x00C8E5B0-0x00C8E5D0
	}

	public class StateRequestQuest_Popup : FSMState<UIPelipper, States> // TypeDefIndex: 7349
	{
		// Fields
		private GameObject popupObj; // 0x18
		private GameObject requestObj; // 0x20
		private bool bUpdate; // 0x28

		// Properties
		public override States StateID { get => default; } // 0x00C8F6F0-0x00C8F700 

		// Constructors
		public StateRequestQuest_Popup() {} // 0x00C80AD0-0x00C80B20

		// Methods
		public override void Enter() {} // 0x00C8F700-0x00C8FE60
		public override void Execute() {} // 0x00C8FE60-0x00C901B0
	}

	public class StateRequestCreate_SendMail : FSMState<UIPelipper, States> // TypeDefIndex: 7350
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8F020-0x00C8F030 

		// Constructors
		public StateRequestCreate_SendMail() {} // 0x00C80990-0x00C809E0

		// Methods
		public override void Enter() {} // 0x00C8F030-0x00C8F2F0
	}

	public class StateReportModeIncoming : FSMState<UIPelipper, States> // TypeDefIndex: 7352
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8E720-0x00C8E730 

		// Constructors
		public StateReportModeIncoming() {} // 0x00C809E0-0x00C80A30

		// Methods
		public override void Enter() {} // 0x00C8E730-0x00C8E7F0
		public override void Execute() {} // 0x00C8E7F0-0x00C8E800
	}

	public class StateInputRevivalPassWord : FSMState<UIPelipper, States> // TypeDefIndex: 7353
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8C2F0-0x00C8C300 

		// Constructors
		public StateInputRevivalPassWord() {} // 0x00C80B20-0x00C80B70

		// Methods
		public override void Enter() {} // 0x00C8C300-0x00C8C460
		public override void Execute() {} // 0x00C8C470-0x00C8C480
		public override void Exit() {} // 0x00C8C480-0x00C8C490
	}

	public class StateInputRescuePassWord : FSMState<UIPelipper, States> // TypeDefIndex: 7355
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8C0A0-0x00C8C0B0 

		// Constructors
		public StateInputRescuePassWord() {} // 0x00C80F80-0x00C80FD0

		// Methods
		public override void Enter() {} // 0x00C8C0B0-0x00C8C210
		public override void Execute() {} // 0x00C8C220-0x00C8C230
		public override void Exit() {} // 0x00C8C230-0x00C8C240
	}

	public class StateInputUserId : FSMState<UIPelipper, States> // TypeDefIndex: 7357
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8C540-0x00C8C550 

		// Constructors
		public StateInputUserId() {} // 0x00C812F0-0x00C81340

		// Methods
		public override void Enter() {} // 0x00C8C550-0x00C8C6A0
	}

	public class StateRequestCreate_Billboard : FSMState<UIPelipper, States> // TypeDefIndex: 7359
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8E800-0x00C8E810 

		// Constructors
		public StateRequestCreate_Billboard() {} // 0x00C80B70-0x00C80BC0

		// Methods
		public override void Enter() {} // 0x00C8E810-0x00C8E8D0
		public override void Execute() {} // 0x00C8E8D0-0x00C8E8E0
		public override void Exit() {} // 0x00C8E8E0-0x00C8E920
		// [IteratorStateMachine] // 0x0064EC50-0x0064ECC0
		private IEnumerator Message() => default; // 0x00C8E920-0x00C8E990
	}

	public class StateRequestCreate_Billboard_Delete : FSMState<UIPelipper, States> // TypeDefIndex: 7361
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8ECA0-0x00C8ECB0 

		// Constructors
		public StateRequestCreate_Billboard_Delete() {} // 0x00C80BC0-0x00C80C10

		// Methods
		public override void Enter() {} // 0x00C8ECB0-0x00C8ED80
		public override void Execute() {} // 0x00C8ED80-0x00C8ED90
	}

	public class StateRequest_Billboard_Close : FSMState<UIPelipper, States> // TypeDefIndex: 7362
	{
		// Properties
		public override States StateID { get => default; } // 0x00C90220-0x00C90230 

		// Constructors
		public StateRequest_Billboard_Close() {} // 0x00C80C10-0x00C80C60

		// Methods
		public override void Enter() {} // 0x00C90230-0x00C902D0
	}

	public class StateConnectInternet_SendMail : FSMState<UIPelipper, States> // TypeDefIndex: 7363
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8B940-0x00C8B950 

		// Constructors
		public StateConnectInternet_SendMail() {} // 0x00C80C60-0x00C80CB0

		// Methods
		public override void Enter() {} // 0x00C8B950-0x00C8BC00
		public override void Execute() {} // 0x00C8BC20-0x00C8BC30
		public override void Exit() {} // 0x00C8BC30-0x00C8BC40
	}

	public class StateConnectInternet_ReGetList : FSMState<UIPelipper, States> // TypeDefIndex: 7367
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8B530-0x00C8B540 

		// Constructors
		public StateConnectInternet_ReGetList() {} // 0x00C81340-0x00C81390

		// Methods
		public override void Enter() {} // 0x00C8B540-0x00C8B780
		public override void Execute() {} // 0x00C8B780-0x00C8B790
	}

	public class StateConnectInternet_GetList : FSMState<UIPelipper, States> // TypeDefIndex: 7369
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8A370-0x00C8A380 

		// Constructors
		public StateConnectInternet_GetList() {} // 0x00C80DF0-0x00C80E40

		// Methods
		public override void Enter() {} // 0x00C8A380-0x00C8A5C0
		public override void Execute() {} // 0x00C8A5C0-0x00C8A5D0
		public override void Exit() {} // 0x00C8A5D0-0x00C8A5E0
	}

	public class StateConnectInternet_GetList_Return : FSMState<UIPelipper, States> // TypeDefIndex: 7371
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8B320-0x00C8B330 

		// Constructors
		public StateConnectInternet_GetList_Return() {} // 0x00C80E40-0x00C80E90

		// Methods
		public override void Enter() {} // 0x00C8B330-0x00C8B530
	}

	public class StateConnectInternet_Achievement : FSMState<UIPelipper, States> // TypeDefIndex: 7372
	{
		// Properties
		public override States StateID { get => default; } // 0x00C88CA0-0x00C88CB0 

		// Constructors
		public StateConnectInternet_Achievement() {} // 0x00C80E90-0x00C80EE0

		// Methods
		public override void Enter() {} // 0x00C88CB0-0x00C89010
		private void Success() {} // 0x00C89010-0x00C890E0
		public override void Execute() {} // 0x00C890E0-0x00C890F0
		public override void Exit() {} // 0x00C890F0-0x00C89100
	}

	public class StateConnectInternet_Confirm : FSMState<UIPelipper, States> // TypeDefIndex: 7374
	{
		// Properties
		public override States StateID { get => default; } // 0x00C89620-0x00C89630 

		// Constructors
		public StateConnectInternet_Confirm() {} // 0x00C80EE0-0x00C80F30

		// Methods
		public override void Enter() {} // 0x00C89630-0x00C89900
		public override void Execute() {} // 0x00C89900-0x00C89910
		public override void Exit() {} // 0x00C89910-0x00C89920
		// [IteratorStateMachine] // 0x0064ED60-0x0064EDD0
		private IEnumerator debugMessage() => default; // 0x00C89920-0x00C89990
	}

	public class StateReportMailList : FSMState<UIPelipper, States> // TypeDefIndex: 7378
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8E640-0x00C8E650 

		// Constructors
		public StateReportMailList() {} // 0x00C80CB0-0x00C80D00

		// Methods
		public override void Enter() {} // 0x00C8E650-0x00C8E700
		public override void Execute() {} // 0x00C8E700-0x00C8E710
		public override void Exit() {} // 0x00C8E710-0x00C8E720
	}

	public class StateUnclaimedMailList : FSMState<UIPelipper, States> // TypeDefIndex: 7379
	{
		// Fields
		private bool bTicketDelete_; // 0x18
		private List<IFriendRescueTicket> list; // 0x20

		// Properties
		public override States StateID { get => default; } // 0x00C91310-0x00C91320 

		// Constructors
		public StateUnclaimedMailList() {} // 0x00C80D00-0x00C80D50

		// Methods
		public override void Enter() {} // 0x00C91320-0x00C915D0
		// [IteratorStateMachine] // 0x0064EDE0-0x0064EE50
		private IEnumerator NoItemMessage() => default; // 0x00C915D0-0x00C91640
		public override void Execute() {} // 0x00C91670-0x00C916F0
	}

	public class StateMailDelete : FSMState<UIPelipper, States> // TypeDefIndex: 7381
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8E3B0-0x00C8E3C0 

		// Constructors
		public StateMailDelete() {} // 0x00C80D50-0x00C80DA0

		// Methods
		public override void Enter() {} // 0x00C8E3C0-0x00C8E3D0
	}

	public class StateInternetBillboard : FSMState<UIPelipper, States> // TypeDefIndex: 7382
	{
		// Fields
		private int openCount_; // 0x18

		// Properties
		public override States StateID { get => default; } // 0x00C8C910-0x00C8C920 

		// Constructors
		public StateInternetBillboard() {} // 0x00C80DA0-0x00C80DF0

		// Methods
		public override void Enter() {} // 0x00C8C920-0x00C8C9B0
		private void enter() {} // 0x00C8C9B0-0x00C8CB00
		private void Open_cb() {} // 0x00C8CB00-0x00C8CB20
		private void Open() {} // 0x00C8CB20-0x00C8CC40
		// [IteratorStateMachine] // 0x0064EE50-0x0064EEC0
		private IEnumerator Hint(bool b, Action cb) => default; // 0x00C8CC40-0x00C8CCC0
		public override void Execute() {} // 0x00C8CCF0-0x00C8CD10
		// [IteratorStateMachine] // 0x0064EEC0-0x0064EF30
		private IEnumerator Message(Action cb) => default; // 0x00C8CD10-0x00C8CD90
	}

	public class StateRankUpMode : FSMState<UIPelipper, States> // TypeDefIndex: 7385
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8E5D0-0x00C8E5E0 

		// Constructors
		public StateRankUpMode() {} // 0x00C80F30-0x00C80F80

		// Methods
		public override void Enter() {} // 0x00C8E5E0-0x00C8E640
	}

	public class StateInternetConfirmTop : FSMState<UIPelipper, States> // TypeDefIndex: 7386
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8D5B0-0x00C8D5C0 

		// Constructors
		public StateInternetConfirmTop() {} // 0x00C80FD0-0x00C81020

		// Methods
		public override void Enter() {} // 0x00C8D5C0-0x00C8D630
	}

	public class StateNotRescued : FSMState<UIPelipper, States> // TypeDefIndex: 7387
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8E3D0-0x00C8E3E0 

		// Constructors
		public StateNotRescued() {} // 0x00C81020-0x00C81070

		// Methods
		public override void Enter() {} // 0x00C8E3E0-0x00C8E450
	}

	public class StateMailClose : FSMState<UIPelipper, States> // TypeDefIndex: 7388
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8E140-0x00C8E150 

		// Constructors
		public StateMailClose() {} // 0x00C810C0-0x00C81110

		// Methods
		public override void Enter() {} // 0x00C8E150-0x00C8E2B0
	}

	public class StateEnd : FSMState<UIPelipper, States> // TypeDefIndex: 7389
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8C060-0x00C8C070 

		// Constructors
		public StateEnd() {} // 0x00C81390-0x00C813E0

		// Methods
		public override void Enter() {} // 0x00C8C070-0x00C8C080
		public override void Execute() {} // 0x00C8C080-0x00C8C090
		public override void Exit() {} // 0x00C8C090-0x00C8C0A0
	}

	public class StateCreatePassword : FSMState<UIPelipper, States> // TypeDefIndex: 7390
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8BF60-0x00C8BF70 

		// Constructors
		public StateCreatePassword() {} // 0x00C81070-0x00C810C0

		// Methods
		public override void Enter() {} // 0x00C8BF70-0x00C8C000
	}

	public class StateInternet_Failed : FSMState<UIPelipper, States> // TypeDefIndex: 7391
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8E0C0-0x00C8E0D0 

		// Constructors
		public StateInternet_Failed() {} // 0x00C81110-0x00C81160

		// Methods
		public override void Enter() {} // 0x00C8E0D0-0x00C8E140
	}

	public class StateInternet_Delete : FSMState<UIPelipper, States> // TypeDefIndex: 7392
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8D630-0x00C8D640 

		// Constructors
		public StateInternet_Delete() {} // 0x00C81160-0x00C811B0

		// Methods
		public override void Enter() {} // 0x00C8D640-0x00C8D820
		// [IteratorStateMachine] // 0x0064EFD0-0x0064F040
		private IEnumerator debugMessage(IFriendRescueTicket mySOS) => default; // 0x00C8D830-0x00C8D8B0
		public override void Execute() {} // 0x00C8D8E0-0x00C8D8F0
		public override void Exit() {} // 0x00C8D8F0-0x00C8D900
	}

	public class StateThanksMode : FSMState<UIPelipper, States> // TypeDefIndex: 7397
	{
		// Properties
		public override States StateID { get => default; } // 0x00C90330-0x00C90340 

		// Constructors
		public StateThanksMode() {} // 0x00C811B0-0x00C81200

		// Methods
		public override void Enter() {} // 0x00C90340-0x00C904A0
		public override void Execute() {} // 0x00C912B0-0x00C912D0
		public override void Exit() {} // 0x00C912D0-0x00C912F0
	}

	public class StateCloseInternetBillboard : FSMState<UIPelipper, States> // TypeDefIndex: 7398
	{
		// Properties
		public override States StateID { get => default; } // 0x00C88B00-0x00C88B10 

		// Constructors
		public StateCloseInternetBillboard() {} // 0x00C812A0-0x00C812F0

		// Methods
		public override void Enter() {} // 0x00C88B10-0x00C88C40
	}

	public class StateConnectInternet_GetList_ForFriend : FSMState<UIPelipper, States> // TypeDefIndex: 7399
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8A7D0-0x00C8A7E0 

		// Constructors
		public StateConnectInternet_GetList_ForFriend() {} // 0x00C81200-0x00C81250

		// Methods
		public override void Enter() {} // 0x00C8A7E0-0x00C8AA10
		public override void Execute() {} // 0x00C8AA10-0x00C8AA20
	}

	public class StateConnectInternet_GetList_ForUserId : FSMState<UIPelipper, States> // TypeDefIndex: 7401
	{
		// Properties
		public override States StateID { get => default; } // 0x00C8ADF0-0x00C8AE00 

		// Constructors
		public StateConnectInternet_GetList_ForUserId() {} // 0x00C81250-0x00C812A0

		// Methods
		public override void Enter() {} // 0x00C8AE00-0x00C8B020
		public override void Execute() {} // 0x00C8B020-0x00C8B030
	}

	private enum InternetDebugType // TypeDefIndex: 7403
	{
		None = 0,
		Upload = 1,
		MailReceive = 2,
		ReGetList = 3
	}

	// Constructors
	public UIPelipper() {} // 0x00C82110-0x00C82120

	// Methods
	private bool IsValidInternetAccess() => default; // 0x00C7EC40-0x00C7ECA0
	private static int CompareDungeonDifficult(IFriendRescueTicket a, IFriendRescueTicket b) => default; // 0x00C7ECA0-0x00C7ED70
	private static int CompareDungeonIndex(IFriendRescueTicket a, IFriendRescueTicket b) => default; // 0x00C7ED70-0x00C7EE60
	private static int CompareDungeonFloor(IFriendRescueTicket a, IFriendRescueTicket b) => default; // 0x00C7EE60-0x00C7EF20
	private static int CompareTimeLimit(IFriendRescueTicket a, IFriendRescueTicket b) => default; // 0x00C7EF20-0x00C7F030
	private static int CompareFriendFavo(IFriendRescueTicket a, IFriendRescueTicket b) => default; // 0x00C7F030-0x00C7F0E0
	public static int CompareTicketList(IFriendRescueTicket a, IFriendRescueTicket b) => default; // 0x00C7F0E0-0x00C7F260
	public static int CompareTicketList_Friend(IFriendRescueTicket a, IFriendRescueTicket b) => default; // 0x00C7F260-0x00C7F3E0
	// [IteratorStateMachine] // 0x0062BB90-0x0062BC00
	public IEnumerator CloseThanksMode() => default; // 0x00C7F3E0-0x00C7F450
	private void OnDestroy() {} // 0x00C7F490-0x00C7F510
	public static UIPelipper Create() => default; // 0x00C7F510-0x00C7F840
	public void Construct() {} // 0x00C7F840-0x00C806A0
	public void Init(FlowPelipper instance) {} // 0x00C813E0-0x00C813F0
	// [IteratorStateMachine] // 0x0062BC00-0x0062BC70
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00C813F0-0x00C81470
	// [IteratorStateMachine] // 0x0062BC70-0x0062BCE0
	public override IEnumerator MainFlow() => default; // 0x00C814A0-0x00C81510
	private void Update() {} // 0x00C81540-0x00C815A0
	public void InternetBillboardDrawUpdate() {} // 0x00C815A0-0x00C815B0
	// [IteratorStateMachine] // 0x0062BCE0-0x0062BD50
	public IEnumerator InternetBillboardPlayOver() => default; // 0x00C81830-0x00C818A0
	// [IteratorStateMachine] // 0x0062BD50-0x0062BDC0
	public IEnumerator CloseMailParts() => default; // 0x00C818D0-0x00C81940
	public string GetInitPassword() => default; // 0x00C81970-0x00C819C0
	public string GetPassword(IFriendRescueTicket ticket) => default; // 0x00C819C0-0x00C81A40
	public string EncodePasswordAndUpdateSOSUniqueKey(IFriendRescueTicket ticket) => default; // 0x00C81AD0-0x00C81B50
	private string EncodePassword(IFriendRescueTicket ticket, bool bUpdateSOSUniqueKey) => default; // 0x00C81A40-0x00C81AD0
	private void SetErrorType(PelipperShopParam.InternetErrorType errorType) {} // 0x00C81B50-0x00C81BD0
	private void ResetErrorType() {} // 0x00C81BD0-0x00C81BF0
	// [IteratorStateMachine] // 0x0062BDC0-0x0062BE30
	private IEnumerator UserIdAndFriendSearch_NoHitMessage(bool bAllReceived) => default; // 0x00C81BF0-0x00C81C70
	public static void SetDateTMPSetter(IFriendRescueTicket ticketData, UIControlTMPSetter setter, bool createTiming = false /* Metadata: 0x00613634 */) {} // 0x00C81CA0-0x00C81E50
	public static void SetDateTMPSetter(PegasusTime.RemainTime remainTime, UIControlTMPSetter setter, bool createTiming = false /* Metadata: 0x00613635 */) {} // 0x00C81E50-0x00C82060
	// [IteratorStateMachine] // 0x0062BE30-0x0062BEA0
	private IEnumerator InternetDebugMessage(InternetDebugType type) => default; // 0x00C82060-0x00C820E0
}

