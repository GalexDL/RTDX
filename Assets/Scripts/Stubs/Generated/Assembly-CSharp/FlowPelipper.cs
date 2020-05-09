/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.dungeon;
using Const.item;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FlowPelipper : FlowPlay // TypeDefIndex: 5301
{
	// Fields
	private HashSet<Const.dungeon.Index> indices_; // 0x90
	private const int REWARD_ITEM_DRAW_NUM = 3; // Metadata: 0x00611260
	private CameraWork cameraWork_; // 0x98
	private bool messageWindowClose; // 0xA0
	public bool internetConfirmRescued; // 0xA1
	private FlowPlayParam param_; // 0xA8
	private bool bankOver_; // 0xB0
	private List<IFriendRescueTicket> tempTicketList_; // 0xB8
	private FriendRescueTicket passwordConfirmTicket_; // 0xC0
	private FriendRescueTicket.FriendRescueTicket_Temp ticketTempData_; // 0xC8
	private bool isNotSucOnlyMyQuest; // 0xD0

	// Properties
	public bool MessageWIndowClose { get => default; set {} } // 0x0081D500-0x0081D510 0x0081D510-0x0081D520

	// Nested types
	public class CameraWork // TypeDefIndex: 5302
	{
		// Fields
		public bool isFirst; // 0x10
		public Vector3 lastPos; // 0x14
		public Quaternion lastRot; // 0x20
		public float lastFov; // 0x30

		// Constructors
		public CameraWork() {} // 0x00998F80-0x00998F90
	}

	private enum CameraSpeedType // TypeDefIndex: 5303
	{
		NONE = 0,
		LOW = 1,
		NORMAL = 2,
		HIGH = 3,
		MAX = 4
	}

	// Constructors
	private FlowPelipper() {} // 0x0081D390-0x0081D420

	// Methods
	public void SetDiscoveryDungeonData() {} // 0x0081D160-0x0081D310
	public bool IsDiscoveryDungeon(Const.dungeon.Index index) => default; // 0x0081D310-0x0081D370
	public void OpenFace() {} // 0x0081D370-0x0081D390
	public static FlowPelipper Create() => default; // 0x0081D420-0x0081D500
	// [IteratorStateMachine] // 0x0061EFC0-0x0061F030
	public override IEnumerator Play(UIManagerBase menuBase, FlowPlayParam param) => default; // 0x0081D520-0x0081D5A0
	private void MoveNext_InternetTimeIsValid() {} // 0x0081D5D0-0x0081D620
	private void SetDungeonQuestBeing(Const.dungeon.Index dungeonIndex) {} // 0x0081D620-0x0081D7D0
	private void MoveNext_MailDataDelete() {} // 0x0081D7D0-0x0081D800
	public void MailDataDelete() {} // 0x0081D800-0x0081D9A0
	private void MoveNext_CheckDungeonResult() {} // 0x0081DAC0-0x0081DB20
	private void MoveNext_CheckReGetChallenge() {} // 0x0081DB20-0x0081DB60
	private bool MoveNext_CheckSOSListCount() => default; // 0x0081DB60-0x0081DC20
	private void MoveNext_CreateTicketFromPass() {} // 0x0081DC20-0x0081DCA0
	private void MoveNext_CheckMySOSTimeOver() {} // 0x0081DCA0-0x0081DDA0
	private void MoveNext_IsTeamNameChange1st() {} // 0x0081DDA0-0x0081DE70
	private void MoveNext_CheckFloorDungeon_Password() {} // 0x0081DE70-0x0081DE80
	private void MoveNext_CheckFloorDungeon_Internet() {} // 0x0081E000-0x0081E080
	private void CheckFloorDungeonBase(Const.dungeon.Index nowDungeonIndex, int nowFloorIndex, uint sosKey) {} // 0x0081DE80-0x0081E000
	private void MoveNext_IsReachingDungeon() {} // 0x0081E080-0x0081E110
	private void MoveNext_IsReachingFloor() {} // 0x0081E110-0x0081E1E0
	private void MoveNext_IsMySOS() {} // 0x0081E1E0-0x0081E230
	private void MoveNext_REQUEST_TUTORIAL() {} // 0x0081E230-0x0081E310
	private void MoveNext_IsReachedDungeon() {} // 0x0081E310-0x0081E3C0
	private void MoveNext_IsReachedFloor() {} // 0x0081E3C0-0x0081E480
	private void MoveNext_RefundTicket() {} // 0x0081E480-0x0081E6D0
	private void MoveNext_CheckRefundOver() {} // 0x0081E6D0-0x0081E720
	private void MoveNext_MySOSIsPay() {} // 0x0081E720-0x0081E7E0
	private void MoveNext_IsBankMax() {} // 0x0081E7E0-0x0081E890
	private void MoveNext_Check_HENSEI_OPEN() {} // 0x0081E890-0x0081E940
	private void MoveNext_Check_RescueWait() {} // 0x0081E940-0x0081E9E0
	private void MoveNext_CheckRescueAnnounce() {} // 0x0081E9E0-0x0081EAC0
	private void MoveNext_IsIncludePerformance() {} // 0x0081EAC0-0x0081EB40
	private void MoveNext_IsIncludeSOSList() {} // 0x0081EB40-0x0081EBA0
	protected override Const.creature.Index GetMasterIndex() => default; // 0x0081EBA0-0x0081EBB0
	protected override string GetTeamData() => default; // 0x0081EBB0-0x0081ECB0
	protected override int GetMoneyData() => default; // 0x0081ECB0-0x0081EE30
	// [IteratorStateMachine] // 0x0061F030-0x0061F0A0
	protected override IEnumerator CloseCommon(Action cb = null) => default; // 0x0081EE30-0x0081EEA0
	protected override void End() {} // 0x0081EED0-0x0081EFA0
	private void NotVisible() {} // 0x0081EFA0-0x0081EFC0
	private void UnLoad() {} // 0x0081F260-0x0081F320
	private void SetVisible_GOKURIN(bool visible) {} // 0x0081EFC0-0x0081F0D0
	private void SetVisible_PELIPPER(bool visible) {} // 0x0081F0D0-0x0081F260
	private void MoveNext_GOKURIN_Display() {} // 0x0081F320-0x0081F350
	private void MoveNext_GOKURIN_Hide() {} // 0x0081F350-0x0081F380
	private void MoveNext_PERIPPER_Display() {} // 0x0081F380-0x0081F3B0
	private void MoveNext_PERIPPER_Hide() {} // 0x0081F3B0-0x0081F3E0
	private void ResetCamera_Peripper() {} // 0x0081F3E0-0x0081F570
	// [IteratorStateMachine] // 0x0061F0A0-0x0061F110
	protected IEnumerator ScriptCall(FlowPlayType type, Action cb = null) => default; // 0x0081F570-0x0081F5F0
	// [IteratorStateMachine] // 0x0061F110-0x0061F180
	private IEnumerator MoveCamera_Peripper(CameraSpeedType type, string cameraTarget = "" /* Metadata: 0x00611242 */, Action cb = null) => default; // 0x0081F5F0-0x0081F680
	private void MoveNext_SetVisible_True() {} // 0x0081F6B0-0x0081F6C0
	private void Set_VISITED_PERIPPER_SHOP() {} // 0x0081F6C0-0x0081F740
	private bool Get_VISITED_PERIPPER_SHOP() => default; // 0x0081F740-0x0081F7C0
	private void Set_CREATE_INTERNET_TICKET() {} // 0x0081F7C0-0x0081F840
	private bool Get_CREATE_INTERNET_TICKET() => default; // 0x0081F840-0x0081F8C0
	private void Set_CREATE_PASSWORD_TICKET() {} // 0x0081F8C0-0x0081F940
	private bool Get_CREATE_PASSWORD_TICKET() => default; // 0x0081F940-0x0081F9C0
	private void Set_VISITED_RESCUE_GATE() {} // 0x0081F9C0-0x0081FA40
	private bool Get_VISITED_RESCUE_GATE() => default; // 0x0081FA40-0x0081FAC0
	// [IteratorStateMachine] // 0x0061F180-0x0061F1F0
	public IEnumerator MoveNext_CheckTest(string message, string ask1 = "\uFFFD" /* Metadata: 0x00611246 */, string ask2 = "\u3044" /* Metadata: 0x00611250 */, Action yesCb = null, Action noCb = null) => default; // 0x0081FAC0-0x0081FB60
	// [IteratorStateMachine] // 0x0061F1F0-0x0061F260
	public IEnumerator MoveNext_ConfirmTest(string message, Action cb = null, bool move = true /* Metadata: 0x0061125D */) => default; // 0x0081FB90-0x0081FC20
	// [IteratorStateMachine] // 0x0061F260-0x0061F2D0
	public IEnumerator TestAsk_Debug(string message, List<string> askList, Action<int> cb) => default; // 0x0081FC50-0x0081FCD0
	private void MoveNext_CheckRescuedCount() {} // 0x0081FCD0-0x0081FD90
	private void MoveNext_CheckType_CONTINUE() {} // 0x0081FD90-0x0081FDF0
	private void MoveNext_CheckSOS_ExceptMine() {} // 0x0081FDF0-0x0081FE40
	private bool CheckSOS_ExceptMine() => default; // 0x0081FE40-0x0081FF40
	private void MoveNext_CheckSelectThanksIsFree() {} // 0x0081FF40-0x0081FFA0
	private void MoveNext_SetLoopCount() {} // 0x0081FFA0-0x008201A0
	private void MoveNext_ThanksLoopCountAdd() {} // 0x008201A0-0x00820240
	private void MoveNext_CheckLoopCount() {} // 0x00820240-0x00820400
	private void MoveNext_CheckSelectTicketType() {} // 0x00820400-0x00820490
	private void MoveNext_CheckUnclaimedMail() {} // 0x00820490-0x00820610
	private void MoveNext_CheckDungeonQuest() {} // 0x00820610-0x008206E0
	private void MoveNext_CheckFromTop() {} // 0x008206E0-0x00820740
	private FriendRescueTicket SearchMyTicket() => default; // 0x00820740-0x00820920
	private void MoveNext_CheckMyRequest() {} // 0x00820920-0x00820970
	private void MoveNext_CheckUnapplied() {} // 0x00820970-0x008209E0
	private void MoveNext_SelfRescueIsSuccess() {} // 0x008209E0-0x00820A50
	private void MoveNext_CheckFirst_InterNet() {} // 0x00820A50-0x00820B60
	private void MoveNext_CheckFirst_Password() {} // 0x00820B60-0x00820C70
	private void MoveNext_CheckFirst_Pripper() {} // 0x00820C70-0x00820D80
	private void MoveNext_CheckFirst_RescueGate() {} // 0x00820D80-0x00820E90
	public IFriendRescueTicket GetMySOS() => default; // 0x0081D9A0-0x0081DAC0
	private void MoveNext_CheckRequestCreateNeed() {} // 0x00820E90-0x00820F60
	private void MoveNext_CheckRescued() {} // 0x00820F60-0x00820F70
	private void MoveNext_RequestIsPassWord() {} // 0x00820F70-0x00821040
	private void MoveNext_CheckRevivePassword() {} // 0x00821040-0x00821050
	private void MoveNext_CheckRevivePasswordBase() {} // 0x00821050-0x00821150
	private void MoveNext_CheckRescuePassword() {} // 0x00821150-0x00821160
	private void MoveNext_CheckRescuePasswordBase() {} // 0x00821160-0x00821260
	private void MoveNext_PasswordIsTimeOver() {} // 0x00821260-0x00821340
	private void MoveNext_ThanksPay() {} // 0x00821340-0x00821580
	private void MoveNext_CheckClearQuest() {} // 0x00821580-0x00821680
	private void MoveNext_IsNotSucOnlyMyQuest() {} // 0x00821680-0x00821710
	private void MoveNext_SetNotSucOnlyMyQuest() {} // 0x00821710-0x008217F0
	private void MoveNext_ConfirmQuestDelete() {} // 0x008217F0-0x00821850
	private void MoveNext_ConfirmQuestReceive(UIPelipper menu) {} // 0x00821850-0x00821940
	private void MoveNext_CheckTemporaryCount() {} // 0x00821940-0x00821A00
	private void MoveNext_PasswordStringReset() {} // 0x00821A00-0x00821A40
	private void MoveNext_CheckSelectQuestContain() {} // 0x00821A40-0x00821CE0
	private void MoveNext_SetRevive() {} // 0x00821CE0-0x00821EE0
	private void MoveNext_SetPresent() {} // 0x00821EE0-0x00821FB0
	// [IteratorStateMachine] // 0x0061F2D0-0x0061F340
	private IEnumerator MoveNext_Liquidation_Pelipper2() => default; // 0x00821FB0-0x00822020
	// [IteratorStateMachine] // 0x0061F340-0x0061F3B0
	private IEnumerator MoveNext_Liquidation_Pelipper(bool leave) => default; // 0x00822050-0x008220C0
	// [IteratorStateMachine] // 0x0061F3B0-0x0061F420
	private IEnumerator MoveNext_GameSaveData_Save() => default; // 0x008220F0-0x00822160
	private void MoveNext_CheckErrorType() {} // 0x00822190-0x008221F0
	private void MoveNext_IsNotInternetError() {} // 0x008221F0-0x00822260
	private void MoveNext_IsUploadError() {} // 0x00822260-0x008222C0
	private void MoveNext_IsMailReceiveError() {} // 0x008222C0-0x00822320
	private void MoveNext_CheckListCount() {} // 0x00822320-0x00822380
	private void MoveNext_CheckMember() {} // 0x00822380-0x00822490
	private void MoveNext_IsRECEIVE_SOS_MAIL() {} // 0x00822490-0x00822540
	private void MoveNext_IsSUCCESS_RESCUE() {} // 0x00822540-0x008225F0
	private void MoveNext_CheckNowExistMySOS() {} // 0x008225F0-0x008226B0
	// [IteratorStateMachine] // 0x0061F420-0x0061F490
	private IEnumerator RescueTopMessege(FlowPlayType playType, bool backUI = false /* Metadata: 0x0061125E */) => default; // 0x008226B0-0x00822740
	// [IteratorStateMachine] // 0x0061F490-0x0061F500
	private IEnumerator RescueTopMessege_FromTop(FlowPlayType playType, bool backUI = false /* Metadata: 0x0061125F */) => default; // 0x00822740-0x008227D0
}

