/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using SpecialAnim;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PerformanceMode // TypeDefIndex: 6267
{
	// Fields
	private Dictionary<uint, PegasusTime.RemainTime> idTimeDictionary_Internet; // 0x10
	private Dictionary<uint, PegasusTime.RemainTime> idTimeDictionary_Password; // 0x18
	private BulletinBoard[] bulletinBoards_; // 0x20
	private Report_Mail reportMail_; // 0x28
	private Unclaimed_Mail unclaimedMail_; // 0x30
	private RevivePasswordWindow passwordWindow_; // 0x38
	private ReceivedRescueTicketListWindow receivedRescueTicketListWindow_; // 0x40
	private DisplayType type_; // 0x48
	private UIPelipper manager_; // 0x50
	private GameObject obj_; // 0x58
	private bool bTicketDelete_; // 0x60
	private bool continueFlag_; // 0x61
	private bool openPass_; // 0x62

	// Properties
	public bool CotinueFlag { get => default; set {} } // 0x00B6F600-0x00B6F610 0x00B6F610-0x00B6F620

	// Nested types
	private enum BulletinBoardElement // TypeDefIndex: 6268
	{
		BG = 0,
		KEISEN = 1,
		LIST = 2,
		TAPE = 3,
		MAX = 4
	}

	private class BulletinBoard : UIWindowBase // TypeDefIndex: 6269
	{
		// Constructors
		public BulletinBoard() {} // 0x00B70BE0-0x00B70BF0
	}

	public class Report_Mail : UIWindowBase // TypeDefIndex: 6270
	{
		// Fields
		private GameObject obj_; // 0x30

		// Constructors
		public Report_Mail() {} // 0x00B70AF0-0x00B70B00

		// Methods
		public override void Init(GameObject obj) {} // 0x00B769A0-0x00B769B0
		public void DataSet(FriendRescueTicket ticketData) {} // 0x00B72060-0x00B72340
		public void Reset() {} // 0x00B73010-0x00B73030
	}

	public class Unclaimed_Mail : UIWindowBase // TypeDefIndex: 6271
	{
		// Fields
		private GameObject obj_; // 0x30

		// Constructors
		public Unclaimed_Mail() {} // 0x00B70B00-0x00B70B10

		// Methods
		public override void Init(GameObject obj) {} // 0x00B76A00-0x00B76A10
		public void DataSet(FriendRescueTicket ticketData, PegasusTime.RemainTime remainTime) {} // 0x00B72340-0x00B72E10
		public void Reset() {} // 0x00B73080-0x00B730A0
	}

	private class RevivePasswordWindow : UIWindowBase // TypeDefIndex: 6272
	{
		// Fields
		private GameObject pass_; // 0x30
		private GameObject pass2_; // 0x38
		private PerformanceMode manager_; // 0x40
		private string[] actionName_; // 0x48
		private Anim<ViewState> anim; // 0x50
		private GameObject obj_; // 0x58
		private ViewState playingState_; // 0x60

		// Properties
		public Anim<ViewState> Anim { get => default; } // 0x00B72E10-0x00B72E20 

		// Nested types
		public enum ViewState // TypeDefIndex: 6273
		{
			NONE = 0,
			PASSOPEN = 1,
			PASSCLOSE = 2,
			DELETE = 3
		}

		// Constructors
		public RevivePasswordWindow() {} // 0x00B70BF0-0x00B70E00

		// Methods
		public void Init(GameObject root, PerformanceMode manager, bool animInit) {} // 0x00B70E00-0x00B70F60
		public void ReInit() {} // 0x00B72E20-0x00B72E30
		public void PlayAnim(ViewState state, Action cb = null) {} // 0x00B73700-0x00B73850
		public void DrawUpdatePassword(DisplayType type, FriendRescueTicket ticket) {} // 0x00B705C0-0x00B708F0
		public void Reset() {} // 0x00B730F0-0x00B73100
	}

	public class ReceivedRescueTicketListWindow : BasicListWindow // TypeDefIndex: 6275
	{
		// Fields
		private PerformanceMode manager_; // 0x88
		private DisplayType type_; // 0x90
		private UIControlTMP pageTmp_; // 0x98
		private GameObject leftButton_; // 0xA0
		private GameObject rightButton_; // 0xA8
		private GameObject objRoot_; // 0xB0
		private GameObject popupObj; // 0xB8
		private TextIDHash defaultHash; // 0xC0
		private CommonScreen commonScreen_; // 0xC8
		private bool isPopuped; // 0xD0
		private bool isMoving; // 0xD1
		private int lastIndex_; // 0xD4

		// Properties
		public int LastIndex { get => default; } // 0x00B6F850-0x00B6F860 

		// Nested types
		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6276
		{
			// Fields
			private IFriendRescueTicket item_; // 0x18
			public bool bDiscovery_; // 0x20
			public PegasusTime.RemainTime remainTime_; // 0x28

			// Properties
			public IFriendRescueTicket Item { get => default; set {} } // 0x00B705B0-0x00B705C0 0x00B75EA0-0x00B75EB0

			// Constructors
			public UILocalSelectItem() {} // 0x00B75E90-0x00B75EA0
		}

		private class UILocalSelector : UISelectorBase // TypeDefIndex: 6277
		{
			// Constructors
			public UILocalSelector() {} // 0x00B75CC0-0x00B75D30

			// Methods
			protected override void SetupFace() {} // 0x00B75EB0-0x00B769A0
		}

		// Constructors
		public ReceivedRescueTicketListWindow() {} // 0x00B70F60-0x00B70F70

		// Methods
		public void Init(GameObject objRoot, PerformanceMode manager, DisplayType type, int defaultIndex = 0 /* Metadata: 0x00612B79 */) {} // 0x00B70F70-0x00B71620
		protected override void _changePage() {} // 0x00B749F0-0x00B74AF0
		protected override void _changeFocus() {} // 0x00B74AF0-0x00B74B20
		protected override void _doInput() {} // 0x00B74B20-0x00B74C00
		private bool popupPassword(bool bVisible) => default; // 0x00B74C00-0x00B75540
		protected override bool _doDecide() => default; // 0x00B75540-0x00B75780
		protected override bool _doCancel() => default; // 0x00B75780-0x00B758E0
		protected override bool _doLeft() => default; // 0x00B758E0-0x00B75950
		protected override bool _doRight() => default; // 0x00B75950-0x00B759C0
		public void Continue() {} // 0x00B759C0-0x00B75A20
	}

	public enum DisplayType // TypeDefIndex: 6280
	{
		Report_Mail = 0,
		Unclaimed_Mail = 1
	}

	// Constructors
	public PerformanceMode() {} // 0x00B72E30-0x00B72E40

	// Methods
	public List<IFriendRescueTicket> DeleteExpiredTicket(out bool bDelete) {
		bDelete = default;
		return default;
	} // 0x00B6ECC0-0x00B6EEC0
	private void SetIdAndTime(List<IFriendRescueTicket> ticketList) {} // 0x00B6F110-0x00B6F4A0
	private PegasusTime.RemainTime GetRemainTime(IFriendRescueTicket ticket) => default; // 0x00B6EEC0-0x00B6F110
	// [IteratorStateMachine] // 0x006255F0-0x00625660
	private IEnumerator OpenBulletinBoards(Action cb = null) => default; // 0x00B6F4A0-0x00B6F520
	// [IteratorStateMachine] // 0x00625660-0x006256D0
	private IEnumerator CloseBulletinBoards(Action cb = null) => default; // 0x00B6F550-0x00B6F5D0
	public void Continue(GameObject rootObj, DisplayType type, UIPelipper manager, bool ticketDelete) {} // 0x00B6F620-0x00B6F850
	public void SetIdAndTime(DisplayType type) {} // 0x00B70970-0x00B70AF0
	public void Init(GameObject rootObj, DisplayType type, UIPelipper manager, bool ticketDelete, int defaultIndex = 0 /* Metadata: 0x00612B51 */) {} // 0x00B6F860-0x00B705B0
	// [IteratorStateMachine] // 0x006256D0-0x00625740
	private IEnumerator AllOpen(Action cb = null) => default; // 0x00B708F0-0x00B70970
	// [IteratorStateMachine] // 0x00625740-0x006257B0
	private IEnumerator AllClose(Action cb = null) => default; // 0x00B716C0-0x00B71740
	// [IteratorStateMachine] // 0x006257B0-0x00625820
	public IEnumerator CloseMailParts(Action cb = null) => default; // 0x00B71770-0x00B717F0
	// [IteratorStateMachine] // 0x00625820-0x00625890
	private IEnumerator OpenAndMessage() => default; // 0x00B71620-0x00B71690
	public void Uninit() {} // 0x00B71850-0x00B71AD0
	public void Update() {} // 0x00B71AD0-0x00B71AE0
	private void ChangeMailContents() {} // 0x00B71AE0-0x00B72060
	private void MailIconActiveOff(GameObject obj) {} // 0x00B70B10-0x00B70BE0
}

