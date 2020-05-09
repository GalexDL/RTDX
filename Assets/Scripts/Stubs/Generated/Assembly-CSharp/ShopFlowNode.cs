/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class ShopFlowNode // TypeDefIndex: 5448
{
	// Fields
	[SerializeField] // 0x00616580-0x00616590
	public string m_cameraTargetName; // 0x10
	[SerializeField] // 0x00616590-0x006165A0
	public string m_scriptFileName; // 0x18
	[SerializeField] // 0x006165A0-0x006165B0
	public string m_scriptExecuteName; // 0x20
	[SerializeField] // 0x006165B0-0x006165C0
	public string m_scriptFileName_another; // 0x28
	[SerializeField] // 0x006165C0-0x006165D0
	public string m_scriptExecuteName_another; // 0x30
	public int m_selectIndex; // 0x38
	public int m_anotherSelectIndex; // 0x3C
	[SerializeField] // 0x006165D0-0x006165E0
	public string m_tagItemName; // 0x40
	[NonSerialized]
	public int m_labelID; // 0x48
	public bool m_bShrink; // 0x4C
	public bool m_bCancel; // 0x4D
	public bool m_bSystem; // 0x4E
	private bool m_bDraw; // 0x4F
	[SerializeField] // 0x006165E0-0x006165F0
	private string m_cursorDataName; // 0x50
	[SerializeField] // 0x006165F0-0x00616600
	public string m_jumpLabel; // 0x58
	public const int m_nodeSizeX = 160; // Metadata: 0x00611419
	public const int m_nodeSizeY = 160; // Metadata: 0x0061141D
	public const int m_knobSizeX = 20; // Metadata: 0x00611421
	public const int m_knobSizeY = 20; // Metadata: 0x00611425
	public const int m_FolderButtonSize = 16; // Metadata: 0x00611429
	[SerializeField] // 0x00616600-0x00616610
	public Vector2 m_nodePos; // 0x60
	public Vector2 m_nodeSize; // 0x68
	private Vector2 m_oldMousePos; // 0x70
	[SerializeField] // 0x00616610-0x00616620
	public NodeType m_type; // 0x78
	[SerializeField] // 0x00616620-0x00616630
	public int m_NodeID; // 0x7C
	[SerializeField] // 0x00616630-0x00616640
	public List<int> m_KnobIDList; // 0x80
	[SerializeField] // 0x00616640-0x00616650
	public string m_messageLabel; // 0x88
	[SerializeField] // 0x00616650-0x00616660
	public string m_messageLabelGraduateCsv; // 0x90
	[SerializeField] // 0x00616660-0x00616670
	public string[] m_rootLabel; // 0x98
	[SerializeField] // 0x00616670-0x00616680
	public string[] m_rootLabelGraduateCsv; // 0xA0
	public bool m_bAnotherModeEdit; // 0xA8
	[SerializeField] // 0x00616680-0x00616690
	public string m_anotherMessageLabel; // 0xB0
	[SerializeField] // 0x00616690-0x006166A0
	public string m_anotherMessageLabelGraduateCsv; // 0xB8
	[SerializeField] // 0x006166A0-0x006166B0
	public string[] m_anotherRootLabel; // 0xC0
	public ShopFlowNode m_anotherNode; // 0xC8
	[SerializeField] // 0x006166B0-0x006166C0
	public string m_targetTagType; // 0xD0
	[SerializeField] // 0x006166C0-0x006166D0
	public string m_targetBufNum; // 0xD8
	[SerializeField] // 0x006166D0-0x006166E0
	public bool[] m_bRootDefault; // 0xE0
	[SerializeField] // 0x006166E0-0x006166F0
	public string m_name; // 0xE8
	[SerializeField] // 0x006166F0-0x00616700
	public bool m_bLock; // 0xF0
	[SerializeField] // 0x00616700-0x00616710
	public bool m_bNotEdit; // 0xF1
	[SerializeField] // 0x00616710-0x00616720
	public int m_outputNum; // 0xF4
	[SerializeField] // 0x00616720-0x00616730
	public int m_allOutputNum; // 0xF8
	[SerializeField] // 0x00616730-0x00616740
	public int m_inputNum; // 0xFC
	private Vector2 m_adjustSize; // 0x100
	[NonSerialized]
	public bool m_move; // 0x108

	// Properties
	public string CursorDataName { get => default; set {} } // 0x009DA850-0x009DA860 0x009DA860-0x009DA870

	// Nested types
	public class SetParam // TypeDefIndex: 5449
	{
		// Fields
		public GUIStyle[] styles; // 0x10

		// Constructors
		public SetParam() {} // 0x009DAFA0-0x009DAFB0
	}

	public enum NodeType // TypeDefIndex: 5450
	{
		None = 0,
		TwoWay = 1,
		MultiRoot = 2,
		ItemBuy = 3,
		ItemSell = 4,
		Useful = 5,
		Start = 6,
		ConfirmationItem = 7,
		ShopItemListReset = 8,
		CheckItemBag = 9,
		AllItemSell = 10,
		ConfirmBuy = 11,
		ConfirmSell = 12,
		CheckBuyResult = 13,
		Message = 14,
		Folder = 15,
		CheckMoney = 16,
		Another = 17,
		Temporary = 18,
		TagSet = 19,
		End = 20,
		CheckBuyItemList = 21,
		ConfirmDraw = 22,
		ConfirmDeposit = 23,
		ItemDeposit = 24,
		ItemDraw = 25,
		CheckDepositItem = 26,
		CheckDrawItem = 27,
		WarehouseItemZeroCheck = 28,
		BagItemZeroCheck = 29,
		CheckSellPossible = 30,
		CheckSellMoneyOver = 31,
		ChoiceOnly = 32,
		BankMoneyZeroCheck = 33,
		BankMoneyMaxCheck = 34,
		BagMoneyMaxCheck = 35,
		BankDeposit = 36,
		BankDraw = 37,
		ConfirmBankDeposit = 38,
		ConfirmBankDraw = 39,
		BagMoneyZeroCheck = 40,
		BagItemMaxCheck = 41,
		ShopItemZeroCheck = 42,
		WarehouseItemMaxCheck = 43,
		PokemonSelect_Renketsu = 44,
		PokemonSelect_Remenber = 45,
		PokemonSelect_Forget = 46,
		PokemonSelect_Learn = 47,
		RenketsuTopMenu_Waza = 48,
		RenketsuMenu_Waza = 49,
		RenketsuGo_Waza = 50,
		BunkaiMenu_Waza = 51,
		BunkaiGo_Waza = 52,
		KeyAllocation_Waza = 53,
		LearnMenu_Waza = 54,
		LearnListMenu_Waza = 55,
		CheckWaza4_Waza = 56,
		WazaChangeMenu_Waza = 57,
		ConfirmLearn_Waza = 58,
		ConfirmProduce_Waza = 59,
		RemenberMenu_Waza = 60,
		ForgetMenu_Waza = 61,
		ConfirmForget_Waza = 62,
		ConfirmWazaChange = 63,
		RenketsuResult_Waza = 64,
		BunkaiResult_Waza = 65,
		RemenberWazaBeing = 66,
		CheckWazaOver2 = 67,
		LearnWazaBeing = 68,
		LearnWazaPay = 69,
		SystemTop_Warehouse = 70,
		SystemTop_Bank = 71,
		CheckDrawOrDeposit = 72,
		JumpNode_Start = 73,
		JumpNode_End = 74,
		CursorDataDeleteNode = 75,
		PostTopMenu = 76,
		PostMenu = 77,
		RequestMenu = 78,
		NewsMenu = 79,
		QuastBoardTopMenu = 80,
		QuastBoardMenu = 81,
		SearchMenu_Camp = 82,
		CampIn = 83,
		PokemonSelect_Camp = 84,
		ActionSelect_Camp = 85,
		GummyConfirm_Camp = 86,
		NickName_Camp = 87,
		PartConfirm_Camp = 88,
		Favorite_Camp = 89,
		ScriptCallNode = 90,
		CampMapOpen = 91,
		CheckNew_Society = 92,
		CheckHide_Society = 93,
		CheckSoldOut_Society = 94,
		CheckPokeList_Society = 95,
		CampList_Society = 96,
		PokemonList_Society = 97,
		Confirm_Society = 98,
		ListReset_Society = 99,
		CallFlowNode = 100,
		CheckMemberBeing_Camp = 101,
		PokemonSelect_Training = 102,
		TicketSelect_Training = 103,
		TutorialSelect_Training = 104,
		CheckTrainingAllClear = 105,
		CheckTutorialAllClear = 106,
		InDungeonMode_Training = 107,
		DungeonMode_Training = 108,
		CheckTutorialResult = 109,
		CheckFirstClear_Training = 110,
		CheckLotteryCount_Training = 111,
		CloseConfirm_Training = 112,
		PokemonSelect_Evolution = 113,
		ConfirmTicketUse_Training = 114,
		ConfirmGetItem_Training = 115,
		Confirm_Evolution = 116,
		NickName_Evolution = 117,
		Rescue_Top = 118,
		MultiRoot_Left = 119,
		TwoWay_Left = 120,
		RequestCreate_PassWord = 121,
		RequestCreate_InterNet = 122,
		CheckRequestCreateNeed = 123,
		CheckRescued = 124,
		RequestIsPassWord = 125,
		CheckFirst_InterNet = 126,
		CheckFirst_PassWord = 127,
		PassWordIsCorrect = 128,
		ThanksPay = 129,
		ConfirmPassWord = 130,
		RevivalPassWord = 131,
		RescuedCompletion = 132,
		CheckThanksIsFree = 133,
		ConnectInterNet = 134,
		ConnectInterNetIsSuc = 135,
		Login = 136,
		LoginIsSuccess = 137,
		DataUpload = 138,
		DataUploadIsSuccess = 139,
		SendRequestMail = 140,
		ReportIncoming = 141,
		UploadToBillboard = 142,
		DeleteMyRequest_Bill = 143,
		CloseMyRequestBill = 144,
		CallDungeonEnterMenu = 145,
		ReportMailList = 146,
		UnclaimedMailList = 147,
		CheckUnclaimedMail = 148,
		CheckClearQuest = 149,
		RankUpMode = 150,
		ThanksLoopStart = 151,
		ThanksLoopCheck = 152,
		ThanksLoopAddCnt = 153,
		CheckSelfRescue = 154,
		SelfRescueIsSuccess = 155,
		ConfirmInternet = 156,
		Call_QUEST_REWARD = 157,
		MailDelete = 158,
		InternetBillboard = 159,
		ConfirmQuestReceive = 160,
		ConfirmQuestDelete = 161,
		CheckSelectQuestContain = 162,
		RescuePassword = 163,
		CheckRescuePassword = 164,
		PasswordStringReset = 165,
		Internet_GetList = 166,
		CheckFromTop = 167,
		CheckFromPelipper = 168,
		Internet_Achievement = 169,
		CheckFirst_Pripper = 170,
		Internet_Confirm = 171,
		EndTypeSet_TERMINATE = 172,
		EndTypeSet_CONTINUE = 173,
		Check_AFTER_ENDING = 174,
		CheckFirst_Waza = 175,
		Check_SHOP_WAZA_OSHIE = 176,
		CheckUnapplied = 177,
		CheckRescuedCount = 178,
		CheckType_CONTINUE = 179,
		PasswordCreate = 180,
		CheckSOS_ExceptMine = 181,
		MailCloseAnim = 182,
		GameSaveData_Save = 183,
		SetRevive = 184,
		SetPresent = 185,
		Liquidation_Pelipper = 186,
		SetCallFlow_Cancel = 187,
		CheckCallFlow_Cancel = 188,
		Internet_Delete = 189,
		SetDungeonRushMode = 190,
		MoveCamera_Peripper = 191,
		ResetCamera_Peripper = 192,
		CheckSelectTicketType = 193,
		ThanksMode = 194,
		CaptionSetNode = 195,
		GuideButtonSetNode = 196,
		CheckTemporaryCount = 197,
		CloseInternetBill = 198,
		DonationNode = 199,
		CheckErrorType = 200,
		GetList_ForUserId = 201,
		GetList_ForFriend = 202,
		CheckFirst_RescueGate = 203,
		Set_EvoBefore = 204,
		Set_EvoAfter = 205,
		Unload_EvoBefore = 206,
		Unload_EvoAfter = 207,
		CheckCameraType_Before = 208,
		CheckCameraType_After = 209,
		FadeInNode = 210,
		FadeOutNode = 211,
		WhiteFadeOutNode = 212,
		InputUserId = 213,
		FadeIn_Long = 214,
		CloseCommonScreen = 215,
		CheckNowExistMySOS = 216,
		CloseMessageWindow = 217,
		MultiRoot_BackUI = 218,
		TwoWay_BackUI = 219,
		Message_BackUI = 220,
		EvolutionAftor = 221,
		EvolutionEnter = 222,
		EvolutionBefore = 223,
		Set_DEFAULT_CAM = 224,
		Fadeout_BGM = 225,
		WaitAnd_ME_EVOLUTION = 226,
		Play_BGM_EVE_LEGEND = 227,
		Fadeout_BGM_Short = 228,
		PlayMENode = 229,
		CheckDungeon_Society = 230,
		CloseList_Society = 231,
		GOKURIN_Display = 232,
		GOKURIN_Hide = 233,
		PERIPPER_Display = 234,
		PERIPPER_Hide = 235,
		IsFavorite_Camp = 236,
		PlaySENode = 237,
		PlayBGMNode = 238,
		Check_HONKI_Release = 239,
		IsSleepMode = 240,
		MultiChoice = 241,
		DeleteDepositItem = 242,
		IsDungeonMode = 243,
		PopUpNode = 244,
		IsBuyInvitation = 245,
		IsNotInternetError = 246,
		IsRECEIVE_SOS_MAIL = 247,
		IsSUCCESS_RESCUE = 248,
		OpenMoneyWindow = 249,
		CloseMoneyWindow = 250,
		IsUploadError = 251,
		IsMailReceiveError = 252,
		OpenMoneyWindow_Bank = 253,
		CloseMoneyWindow_Bank = 254,
		Rescue_Top_FromTop = 255,
		CheckHasDualType_Training = 256,
		SetFirstType_Training = 257,
		SetSecondType_Training = 258,
		PasswordIsTimeOver = 259,
		ConfirmPassword_Other = 260,
		IsIncludePerformance = 261,
		IsIncludeSOSList = 262,
		FadeIn_Short = 263,
		FadeOut_Short = 264,
		CameraAndScript = 265,
		MessageAndScript = 266,
		Camera_Speed = 267,
		Camera_HighSpeed = 268,
		CameraAndScript_Speed = 269,
		CameraAndScript_HighSpeed = 270,
		CheckRescueAnnounce = 271,
		CheckEvoPokemonCount = 272,
		CheckScarf = 273,
		OpenSubWindow_Shop = 274,
		CloseSubWindow_Shop = 275,
		OpenSubWindow_Warehouse = 276,
		CloseSubWindow_Warehouse = 277,
		Check_HENSEI_OPEN = 278,
		Check_RescueWait = 279,
		IsNotTSUCHININ = 280,
		SetContinue_Bil = 281,
		ReleaseContinue_Bill = 282,
		CheckRefundOver = 283,
		RefundTicket = 284,
		MySOSIsPay = 285,
		IsBankMax = 286,
		Reward_NUKENIN = 287,
		Reward_Tutorial = 288,
		IsOverBagMoney = 289,
		IsOverBank = 290,
		MoneyAddBank = 291,
		IsHonkiSuccess = 292,
		BGMFadeOutStart = 293,
		CheckDungeonQuest = 294,
		IsReachedDungeon = 295,
		IsReachedFloor = 296,
		IsREQUEST_TUTORIAL = 297,
		DisappearCommon = 298,
		IsMySOS = 299,
		IsReachingDungeon = 300,
		IsReachingFloor = 301,
		CheckFloorDungeonP = 302,
		CheckFloorDungeonI = 303,
		IsTeamNameChange1st = 304,
		CheckMySOSTimeOver = 305,
		CloseThanksMode = 306,
		TicketDelete = 307,
		CheckBankBonus = 308,
		BankBonus_Reward = 309,
		CheckListCount = 310,
		CheckMember = 311,
		WaitTime = 312,
		Liquidation_DontLeave = 313,
		CloseButtonGuide = 314,
		CloseButtonGuide_Wait = 315,
		CreateTicketFromPass = 316,
		CheckSOSListCount = 317,
		CheckUseItemCount = 318,
		CheckReGetChallenge = 319,
		DungeonIsFailure = 320,
		CheckGetTicket = 321,
		OpenEvolutionInfo = 322,
		CloseEvolutionInfo = 323,
		MailDataDelete = 324,
		RewardIsSingular = 325,
		Message_Plural = 326,
		InternetTimeIsValid = 327,
		IsNotSucOnlyMyQuest = 328,
		SetNotSucOnlyMyQuest = 329,
		ConfirmPassword_Popup = 330,
		IsHero = 331,
		MailCloseAnim_NoSe = 332,
		CheckSOSListCount_NoSe = 333
	}

	protected delegate void CancelTimngAction(); // TypeDefIndex: 5451; 0x009DABD0-0x009DAF50

	// Constructors
	public ShopFlowNode() {} // 0x009CFAC0-0x009CFB80

	// Methods
	protected void CreateAnotherNode<T>()
		where T : ShopFlowNode, new() {}
	protected void UpdateAnotherNode() {} // 0x009DA870-0x009DA880
	public static ShopFlowNode SearchNode(int ID) => default; // 0x009DA880-0x009DAA40
	public virtual void UpdateGamePlay() {} // 0x009DAA40-0x009DAA50
	protected void Cancel(int localKnobID) {} // 0x009DAA50-0x009DAAE0
	protected void Cancel(int localKnobID, CancelTimngAction[] action) {} // 0x009DAAE0-0x009DABD0
}

