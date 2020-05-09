/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIBulletinBoard : UICommonBulletinBoard // TypeDefIndex: 6485
{
	// Fields
	private ButtonSelectWindow buttonSelect_; // 0x38
	private NewsViewWindow newsViewWindow_; // 0x40
	private UIAskMenu actionMenu_; // 0x48
	private QuestCautionWindow questCautionWindow_; // 0x50
	private QuestReceiptInfo questReceiptInfo_; // 0x58
	private bool bMailboxException_; // 0x60
	private TopMenuSelectType topMenuSelect_; // 0x64
	private TopMenuSelectType[] topMenuSelectIds_; // 0x68
	private int focusIndex_; // 0x70
	private BillboardQuestSelectType billboardQuestSelect_; // 0x74
	private TrustQuestSelectType trustQuestSelect_; // 0x78
	private NewsBoardSelectType newsBoardSelect_; // 0x7C
	private MailBoxSelectType mailBoxSelect_; // 0x80
	private RefuseQuestSelectType refuseQuestSelect_; // 0x84

	// Nested types
	public enum TopMenuSelectType // TypeDefIndex: 6486
	{
		Cancel = -1,
		None = 0,
		BulletinBoard = 1,
		RequestsReceived = 2,
		WatchThePost = 3,
		ReadTheNews = 4
	}

	public enum BillboardQuestSelectType // TypeDefIndex: 6487
	{
		Cancel = -1,
		None = 0,
		EventExit = 1
	}

	public enum TrustQuestSelectType // TypeDefIndex: 6488
	{
		Cancel = -1,
		None = 0
	}

	public enum NewsBoardSelectType // TypeDefIndex: 6489
	{
		Cancel = -1,
		None = 0
	}

	public enum MailBoxSelectType // TypeDefIndex: 6490
	{
		Cancel = -1,
		None = 0
	}

	public enum RefuseQuestSelectType // TypeDefIndex: 6491
	{
		Cancel = -1,
		None = 0,
		Decide = 1
	}

	public enum RefuseQuestFlowType // TypeDefIndex: 6492
	{
		None = 0,
		Duplicate = 1,
		Full = 2,
		FullAndAllSuspendedDungeonQuest = 3
	}

	// Constructors
	public UIBulletinBoard() {} // 0x007F2AD0-0x007F2AE0

	// Methods
	public static UIBulletinBoard Create() => default; // 0x007DBF80-0x007DC140
	public void Construct() {} // 0x007EC210-0x007EC790
	public void Destruct() {} // 0x007DC240-0x007DC2D0
	private void commonInitQuestReciptInfo() {} // 0x007EC790-0x007EC880
	private void commonEndQuestReciptInfo() {} // 0x007EC880-0x007EC890
	private void _topMenuButtonCount(GameObject button, int count) {} // 0x007EC890-0x007ECAC0
	// [IteratorStateMachine] // 0x00627060-0x006270D0
	public IEnumerator QuestBoardTopMenuMainFlow(int defaultIndex, Action<TopMenuSelectType> cb = null) => default; // 0x007ECAC0-0x007ECB40
	// [IteratorStateMachine] // 0x006270D0-0x00627140
	public IEnumerator PostTopMenuMainFlow(int defaultIndex, Action<TopMenuSelectType> cb = null) => default; // 0x007ECB40-0x007ECBC0
	public int GetFocusIndex() => default; // 0x007ECBC0-0x007ECBD0
	private void _cbFromTopMenu(ListWindowBase.ActionType act) {} // 0x007ECBD0-0x007ECE10
	private static int TicketCompare(TicketListInfo a, TicketListInfo b) => default; // 0x007ECE10-0x007ECE40
	public void InitQuestBoard() {} // 0x007ECE40-0x007ED2D0
	// [IteratorStateMachine] // 0x00627140-0x006271B0
	public IEnumerator QuestBoardMainFlow(Action<BillboardQuestSelectType> cb = null) => default; // 0x007ED2D0-0x007ED350
	public void ContinueQuestBoard() {} // 0x007ED350-0x007ED360
	public void EndQuestBoard() {} // 0x007ED360-0x007ED370
	private void _cbFromQuestBoardList(ListWindowBase.ActionType act) {} // 0x007ED370-0x007ED5C0
	private void _onStartBillboardQuestSelect() {} // 0x007ED5C0-0x007ED750
	// [IteratorStateMachine] // 0x006271B0-0x00627220
	private IEnumerator _onPopupBillboardQuestSelect(TicketListInfo tInfo) => default; // 0x007ED750-0x007ED7D0
	private void _onEndBillboardQuestSelect(bool bBulletinBoardExit = false /* Metadata: 0x00612DC4 */) {} // 0x007ED7D0-0x007ED960
	public void InitTrustQuest() {} // 0x007ED960-0x007EDDE0
	// [IteratorStateMachine] // 0x00627220-0x00627290
	public IEnumerator TrustQuestMainFlow(Action<TrustQuestSelectType> cb = null) => default; // 0x007EDDE0-0x007EDE60
	public void ContinueTrustQuest() {} // 0x007EDE60-0x007EDE70
	public void EndTrustQuest() {} // 0x007EDE70-0x007EDE80
	private void _cbFromTrustQuestList(ListWindowBase.ActionType act) {} // 0x007EDE80-0x007EE050
	private void _onStartTrustQuestSelect(int defaultIndex = 0 /* Metadata: 0x00612DC5 */) {} // 0x007EE050-0x007EE430
	private void _onDecideTrustQuestSelect(int act) {} // 0x007EE4B0-0x007EED10
	private void _onChangeStatusQuest(TextId textId, TextId textId2) {} // 0x007EF3C0-0x007EF550
	private void _onChangeStatusQuestEnd() {} // 0x007EF590-0x007EF6C0
	private void _onEndTrustQuestSelect() {} // 0x007EF550-0x007EF590
	private void _removeTrustQuest() {} // 0x007EED10-0x007EF070
	private void _removeTrustQuestEnd(GameObject selObj) {} // 0x007EF6C0-0x007EF950
	private void _onTrustQuestEmpty() {} // 0x007EF950-0x007EFA30
	private void _onStartTrustCaution() {} // 0x007EF070-0x007EF3C0
	// [IteratorStateMachine] // 0x00627290-0x00627300
	private IEnumerator AskQuestRemove(bool bWander, Action<int> cb = null) => default; // 0x007EFA30-0x007EFAC0
	private void _onQuestRemove_ask(bool bWander) {} // 0x007EFAC0-0x007EFBF0
	private void _onQuestRemove_close(int yn) {} // 0x007EFBF0-0x007EFE40
	// [IteratorStateMachine] // 0x00627300-0x00627370
	private IEnumerator WarningEventRequest(TextIDHash textHash, Action cb = null) => default; // 0x007EE430-0x007EE4B0
	private static int NewsTicketCompare(TicketListInfo a, TicketListInfo b) => default; // 0x007EFE40-0x007EFF40
	public void InitNewsBoard() {} // 0x007EFF40-0x007F0360
	// [IteratorStateMachine] // 0x00627370-0x006273E0
	public IEnumerator NewsBoardMainFlow(Action<NewsBoardSelectType> cb = null) => default; // 0x007F0360-0x007F03E0
	public void ContinueNewsBoard() {} // 0x007F03E0-0x007F03F0
	public void EndNewsBoard() {} // 0x007F03F0-0x007F0400
	private void _cbFromNewsBoardList(ListWindowBase.ActionType act) {} // 0x007F0400-0x007F0520
	private void _onStartNewsBoardSelect() {} // 0x007F0520-0x007F05C0
	private void _onEndNewsBoardSelect() {} // 0x007F08F0-0x007F0930
	private void _onStartNewsRead() {} // 0x007F05C0-0x007F08F0
	private void _onEndNewsRead() {} // 0x007F0930-0x007F09A0
	private void _cbFromNewsReadAction(NewsViewWindow.ActionType act) {} // 0x007F0C50-0x007F0D50
	private List<IQuestTicket> _getPostTicketList() => default; // 0x007F0D50-0x007F0F10
	public void InitMailBox() {} // 0x007F0F10-0x007F1370
	// [IteratorStateMachine] // 0x006273E0-0x00627450
	public IEnumerator MailBoxMainFlow(Action<MailBoxSelectType> cb = null) => default; // 0x007F1370-0x007F13F0
	public void ContinueMailBox() {} // 0x007F13F0-0x007F1400
	public void EndMailBox() {} // 0x007F1400-0x007F1410
	private void _cbFromMailBoxList(ListWindowBase.ActionType act) {} // 0x007F1410-0x007F16F0
	private void _removeMailBox() {} // 0x007F16F0-0x007F1920
	private void _onMailBoxEmpty() {} // 0x007F1920-0x007F1A00
	private void _onMailBoxNewsReadEnd() {} // 0x007F09A0-0x007F0C50
	private void _onMailBoxGetPresent() {} // 0x007F1A00-0x007F1DB0
	private void _onMailBoxGetPresentReward(UIRewardMenu.RewardParam param) {} // 0x007F1DB0-0x007F1EB0
	private void _onMailBoxGetPresentEnd() {} // 0x007F1EB0-0x007F2070
	private void Start() {} // 0x007F2070-0x007F2080
	private void Update() {} // 0x007F2080-0x007F20E0
	public void InitRefuseQuest(RefuseQuestFlowType flowType, QuestWonderMailTicket ticket) {} // 0x007DC4E0-0x007DCA70
	// [IteratorStateMachine] // 0x00627450-0x006274C0
	public IEnumerator RefuseQuestMainFlow(bool bIsFull, Action<bool> cb = null) => default; // 0x007DCA70-0x007DCB00
	private void _cbFromRefuseQuestList(ListWindowBase.ActionType act) {} // 0x007F20E0-0x007F22C0
	private void _onStartRefuseQuestSelect(int defaultIndex = 0 /* Metadata: 0x00612DC9 */) {} // 0x007F22C0-0x007F2470
	private void _onStartRefuseCaution() {} // 0x007F2470-0x007F27C0
	private void _onQuestRefuse_ask(bool bWonder) {} // 0x007F27C0-0x007F28E0
	private void _onQuestRefuse_close(int yn) {} // 0x007F2960-0x007F2A60
	// [IteratorStateMachine] // 0x006274C0-0x00627530
	private IEnumerator AskQuestRemoveWonderMail(bool bWonder, Action<int> cb = null) => default; // 0x007F28E0-0x007F2960
	// [IteratorStateMachine] // 0x00627530-0x006275A0
	public IEnumerator DisplayWonderMail(QuestWonderMailTicket ticket, int captionHash, string password) => default; // 0x007DC140-0x007DC1D0
	// [IteratorStateMachine] // 0x006275A0-0x00627610
	public IEnumerator OpenWonderMail() => default; // 0x007F2A60-0x007F2AD0
	public void UpdateWonderMail(QuestWonderMailTicket ticket) {} // 0x007DC2D0-0x007DC4E0
	// [IteratorStateMachine] // 0x00627610-0x00627680
	public IEnumerator CloseWonderMail() => default; // 0x007DC1D0-0x007DC240
}

