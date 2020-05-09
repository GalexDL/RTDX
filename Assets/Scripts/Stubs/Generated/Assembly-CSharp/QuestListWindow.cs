/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class QuestListWindow : BasicListWindow // TypeDefIndex: 6460
{
	// Fields
	private bool bDisableDecide_; // 0x84

	// Properties
	public bool DisableDecide { get => default; set {} } // 0x009F3910-0x009F3920 0x009F31B0-0x009F31C0

	// Nested types
	public enum ViewType // TypeDefIndex: 6461
	{
		BulletinBoard = 0,
		Post = 1,
		QuestList = 2,
		NewsList = 3,
		QuestList_WonderMail = 4
	}

	public enum CaptionType // TypeDefIndex: 6462
	{
		TRUST_QUEST = 0,
		BILLBOARD_QUEST = 1,
		NEWS = 2
	}

	public class UILocalSelectItem : UISelectItem // TypeDefIndex: 6463
	{
		// Fields
		private TicketListInfo item_; // 0x18

		// Properties
		public TicketListInfo Item { get => default; set {} } // 0x009F5840-0x009F5850 0x009F56E0-0x009F56F0

		// Constructors
		public UILocalSelectItem() {} // 0x009F56D0-0x009F56E0
	}

	protected class UILocalSelector : UISelectorBase // TypeDefIndex: 6464
	{
		// Fields
		private ViewType viewType_; // 0x2C

		// Properties
		public ViewType ViewType { set {} } // 0x009F5830-0x009F5840

		// Constructors
		public UILocalSelector() {} // 0x009F57C0-0x009F5830

		// Methods
		protected override void SetupFace() {} // 0x009F5850-0x009F58F0
	}

	// Constructors
	public QuestListWindow() {} // 0x009F55C0-0x009F55D0

	// Methods
	public void Init(GameObject objRoot, List<TicketListInfo> list, ViewType viewType = ViewType.BulletinBoard /* Metadata: 0x00612D94 */) {} // 0x009F3070-0x009F31A0
	public bool GetEnable(ViewType type, TicketListInfo info) => default; // 0x009F31C0-0x009F3580
	public void SetCaption(CaptionType cap) {} // 0x009F37B0-0x009F3910
	protected override bool _doDecide() => default; // 0x009F3920-0x009F3940
	public static void DrawFace(GameObject face, TicketListInfo ticketInfo, ViewType viewType) {} // 0x009F3940-0x009F51D0
}

