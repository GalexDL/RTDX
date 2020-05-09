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

public class RescueRequestWindow : UIWindowBase // TypeDefIndex: 6361
{
	// Fields
	private bool bContinue_; // 0x30
	private UIState uiState_; // 0x34
	private bool[] uiStateInis; // 0x38
	private UIPelipper manager_; // 0x40
	private UIControlTMPSetter thanksSetter_; // 0x48
	private UIControlTMPSetter thanksSetterPrice_; // 0x50
	private GameObject thanksLeft_; // 0x58
	private GameObject thanksRight_; // 0x60
	private GameObject thanksSelectWindow_; // 0x68
	private GameObject thanksSelectWindowBg_; // 0x70
	private GameObject thanksText; // 0x78
	private GameObject thanksEffect; // 0x80
	private GameObject sendButton_; // 0x88
	private GameObject passwordButton_; // 0x90
	private MailOutside mailOutside_; // 0x98
	private MailContents mailContents_; // 0xA0
	private PassWord password_; // 0xA8
	private PassWord passwordPopup_; // 0xB0
	private bool interNet_; // 0xB8
	private bool check_; // 0xB9
	private CommonPokeBankInfo bankInfoWindow_; // 0xC0
	private bool bMessage; // 0xC8
	private bool bThanksSetMessage_; // 0xC9

	// Properties
	public bool ContinueFlag { get => default; set {} } // 0x00828FB0-0x00828FC0 0x00828FC0-0x00828FD0
	public MailOutside MailOutSidePro { get => default; } // 0x008292A0-0x008292B0 

	// Nested types
	public enum ThanksType // TypeDefIndex: 6362
	{
		Regular = 0,
		Special = 1,
		Deluxe = 2
	}

	public enum UIState // TypeDefIndex: 6363
	{
		None = 0,
		In_Mail = 1,
		ThanksSetMessage = 2,
		ThanksSelect = 3,
		ThanksCheck = 4,
		Send_Mail = 5,
		Done = 6,
		CheckMessage = 7,
		DeleteRescueRequest = 8,
		MAX = 9
	}

	private class PassWord // TypeDefIndex: 6364
	{
		// Fields
		private string[] actionName_; // 0x10
		private Anim<ViewState> anim; // 0x18
		private UIPelipper manager_; // 0x20
		private IFriendRescueTicket tiket_; // 0x28
		private GameObject pass_; // 0x30
		private GameObject pass2_; // 0x38

		// Nested types
		public enum ViewState // TypeDefIndex: 6365
		{
			NONE = 0,
			FADEIN = 1,
			PASSOPEN = 2,
			PASSCLOSE = 3
		}

		// Constructors
		public PassWord() {} // Dummy constructor
		public PassWord(GameObject obj, UIPelipper manager, FriendRescueTicket _ticket, bool check) {} // 0x0082B940-0x0082BD80

		// Methods
		public void ResetPass() {} // 0x00829330-0x008293B0
		public void PlayAnim(ViewState state, Action cb = null) {} // 0x0082E310-0x0082E410
		public void DrawPassword(FriendRescueTicket ticket) {} // 0x0082C720-0x0082C750
		public void DrawPassword(string message) {} // 0x0082DFF0-0x0082E310
	}

	private class MailContents // TypeDefIndex: 6366
	{
		// Fields
		private string[] actionName_; // 0x10
		private Anim<ViewState> anim; // 0x18

		// Nested types
		public enum ViewState // TypeDefIndex: 6367
		{
			NONE = 0,
			MOVE = 1,
			OPENSELECT = 2,
			CLOSESELECT = 3
		}

		// Constructors
		public MailContents() {} // Dummy constructor
		public MailContents(GameObject obj) {} // 0x0082B700-0x0082B940

		// Methods
		public void PlayAnim(ViewState state, Action cb = null) {} // 0x0082CB30-0x0082CC30
		public bool IsViewState(ViewState viewState) => default; // 0x0082CAC0-0x0082CB30
	}

	public class MailOutside // TypeDefIndex: 6368
	{
		// Fields
		private string[] actionNames; // 0x10
		private Anim<ViewState> anim; // 0x18

		// Nested types
		public enum ViewState // TypeDefIndex: 6369
		{
			NONE = 0,
			MAIL_OPEN = 1,
			MAIL_PASS_OPEN = 2,
			MAIL_PASS_DELETE = 3,
			MAIL_PASS_INSERT = 4,
			MAIL_INSERT = 5,
			MAIL_MOVE = 6,
			MAIL_CLOSE = 7,
			MAIL_CHANGE = 8,
			MAIL_RESET = 9,
			MAIL_MAILSLIDEPASSIN = 10
		}

		// Constructors
		public MailOutside() {} // Dummy constructor
		public MailOutside(GameObject obj) {} // 0x0082B1E0-0x0082B700

		// Methods
		public void PlayAnim(ViewState state, Action cb = null) {} // 0x0082C750-0x0082C8A0
		public void PlayAnim_CloseAndChange(Action cb = null) {} // 0x0082CA10-0x0082CAC0
		public bool IsViewState(ViewState viewState) => default; // 0x0082D520-0x0082D590
	}

	// Constructors
	public RescueRequestWindow() {} // 0x0082D590-0x0082D5F0

	// Methods
	public static void PlaySe_LetterIn() {} // 0x00828FD0-0x00829050
	public static void PlaySe_LetterOpen() {} // 0x00829050-0x008290D0
	public static void PlaySe_LetterClose() {} // 0x008290D0-0x00829150
	public static void PlaySe_LetterOut() {} // 0x00829150-0x008291D0
	public static void PlaySe_LetterFall() {} // 0x008291D0-0x00829250
	public void SetUIState(UIState state, bool init = true /* Metadata: 0x00612C6D */) {} // 0x00829250-0x008292A0
	public void ResetPassword() {} // 0x008292B0-0x00829330
	public virtual void Init(GameObject objRoot, UIPelipper manager, bool interNet, bool check, FriendRescueTicket ticket, bool passOpen = true /* Metadata: 0x00612C6E */) {} // 0x008293B0-0x0082B070
	// [IteratorStateMachine] // 0x00626070-0x006260E0
	private IEnumerator Hint(bool over, Action cb) => default; // 0x0082BD80-0x0082BE00
	public override void Update() {} // 0x0082BE30-0x0082BE40
	public void CreatePassword(Action cb = null) {} // 0x0082C240-0x0082C720
	// [IteratorStateMachine] // 0x006260E0-0x00626150
	private IEnumerator ThanksSetMessage() => default; // 0x0082C8A0-0x0082C910
	private void CloseAndReset(Action cb) {} // 0x0082C940-0x0082CA00
	protected void _update() {} // 0x0082BE40-0x0082C240
	private void SetAlphaZero(GameObject obj) {} // 0x0082B130-0x0082B1E0
	private void SetAlphaOne(GameObject obj) {} // 0x0082B080-0x0082B130
	private void Update_ThanksSelect() {} // 0x0082CC30-0x0082D2F0
	public void Update_DeleteRescueRequest() {} // 0x0082D2F0-0x0082D520
}

