/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using window;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A750-0x0060A760
public class MessageWindow : SingletonMonoBehaviour<MessageWindow> // TypeDefIndex: 8069
{
	// Fields
	public UIMessageWindow MessageWindowUISrc; // 0x18
	private UIMessageWindow ui_; // 0x20
	public UIFaceWindow FaceWindowUISrc; // 0x28
	private UIFaceWindow face_; // 0x30
	public const int DEFAULT_WINDOW_PRIORITY = 8; // Metadata: 0x00613DBA
	private const int DEFAULT_AUTO_CLOSE_FRAME = -1; // Metadata: 0x00613DBE
	private const int REPLAY_AUTO_CLOSE_FRAME = 30; // Metadata: 0x00613DC2
	public const int MAX_PERMEBILITY = 256; // Metadata: 0x00613DC6
	private const int AUTO_PLAY_NOTICE_WAIT_FRAME = 30; // Metadata: 0x00613DCA
	private static Point aNoticeOffsetClient; // 0x00
	private static Point aInfomationOffsetClient; // 0x08
	private static Point aTalkOffsetClient; // 0x10
	private static int[] aSpeeds; // 0x18
	private static RectangleS32 noticeWindowRect; // 0x20
	private static RectangleS32 noticeWindowInfomationRect; // 0x30
	private static RectangleS32 talkWindowRect; // 0x40
	private static string[] s_apSystemVoiceTable; // 0x50
	private const int VALUE_MESSAGE_BSKIP_SPEED = 2; // Metadata: 0x00613DCE
	private SystemVoice m_voice; // 0x38
	private bool m_bSound; // 0x3C
	private bool m_bScriptMode; // 0x3D
	private CancelState m_cancelState; // 0x40
	private KeyWaitMode m_eKeyWaitMode; // 0x44
	private int m_nKeyWaitTimeWait; // 0x48
	private bool m_bNowTalk; // 0x4C
	private bool m_bHideFrame; // 0x4D
	private int m_nAutoCloseFrame; // 0x50
	private int m_nPriority; // 0x54
	private bool m_bOnlyCancelKey; // 0x58
	private bool m_bStartKeyOffWait; // 0x59
	private int m_nStartKeyWait; // 0x5C
	private bool m_bLButtonDecideStop; // 0x60

	// Properties
	public UIFaceWindow FaceWindow { get => default; } // 0x00897F70-0x00897F80 

	// Nested types
	[Flags] // 0x00612BE0-0x00612BF0
	public enum NoticeMode // TypeDefIndex: 8070
	{
		NOTICE_MODE_NONE = 0,
		NOTICE_MODE_NOT_CLOSE = 1,
		NOTICE_MODE_NOT_KEY_WAIT = 2,
		NOTICE_MODE_NOT_KEY_CLOSE = 3,
		NOTICE_MODE_SAVE = 3,
		NOTICE_MODE_FRAME_NONE = 4,
		NOTICE_MODE_TALK_OFFSET = 16,
		NOTICE_MODE_TRANSPARENCY = 32,
		NOTICE_MODE_TALK_WINDOW = 64,
		NOTICE_MODE_BLACK_FONT = 128,
		NOTICE_MODE_TALK_NOT_KEY_CLOSE = 195,
		NOTICE_MODE_INFOMATION_WINDOW = 256,
		NOTICE_MODE_LOG_WINDOW = 512,
		NOTICE_MODE_OUTLINE_LINE_PITCH = 1024,
		NOTICE_MODE_ONLY_CANCEL_KEY = 2048,
		NOTICE_MODE_WHITE_FONT = 8192,
		NOTICE_MODE_FORCE_CHAPTER_FONT = 16384
	}

	public enum KeyWaitMode // TypeDefIndex: 8071
	{
		KEYWAIT_MODE_NORMAL = 0,
		KEYWAIT_MODE_TIME_WAIT = 1
	}

	public enum SystemVoice // TypeDefIndex: 8072
	{
		SYSTEM_VOICE_NORMAL = 0,
		SYSTEM_VOICE_TALK = 1,
		SYSTEM_VOICE_MAX = 2,
		SYSTEM_VOICE_NONE = 2
	}

	public enum CancelState // TypeDefIndex: 8073
	{
		CANCEL_STATE_OFF = 0,
		CANCEL_STATE_ON = 1,
		CANCEL_STATE_DONE = 2
	}

	public class AskParam // TypeDefIndex: 8074
	{
		// Fields
		public TalkType talkType; // 0x10
		public string mastarName; // 0x18
		public List<UIGeneralMenu.Item> askItems; // 0x20
		public int defaultIndex; // 0x28
		public UIAskMenu.Place askPlace; // 0x2C
		public bool askEnableCancel; // 0x30
		public int waitFrame; // 0x34
		public bool bAutoClose; // 0x38

		// Nested types
		public enum TalkType // TypeDefIndex: 8075
		{
			TALK = 0,
			SYSTEM = 1,
			ASKONLY = 2
		}

		// Constructors
		public AskParam() {} // 0x00E316F0-0x00E31780
	}

	private enum Step_ // TypeDefIndex: 8076
	{
		STEP_DRAW_TEXT = 0,
		STEP_ANALYZE_CODE = 1,
		STEP_EXIT = 2
	}

	private class ParseText_ // TypeDefIndex: 8077
	{
		// Fields
		public ushort[] szText; // 0x10
		public int readTxtIdx; // 0x18
		public int writeTxtIdx; // 0x1C

		// Constructors
		public ParseText_() {} // Dummy constructor
		public ParseText_(int size) {} // 0x00E2E070-0x00E2E0E0

		// Methods
		public void AddText_(ushort ch) {} // 0x00E2E0E0-0x00E2E140
		public void AddText_(ushort[] text) {} // 0x00E2E140-0x00E2E1F0
		public void SetReadOffset_(int offset) {} // 0x00E31780-0x00E31790
		public void AddReadOffset_(int offset) {} // 0x00E31790-0x00E317A0
		public ushort PopText_() => default; // 0x00E31210-0x00E31260
		public ushort PeekChar_() => default; // 0x00E311C0-0x00E31210
		public ushort PeekCharOffs_(int offs) => default; // 0x00E317A0-0x00E317F0
		public ushort[] GetRestText_() => default; // 0x00E317F0-0x00E31870
		public ushort[] GetText_(int startIndex) => default; // 0x00E31260-0x00E312F0
	}

	// Constructors
	public MessageWindow() {} // 0x00898FB0-0x00899040
	static MessageWindow() {} // 0x00899040-0x00899310

	// Methods
	private void OnEnable() {} // 0x00897B40-0x00897BE0
	private void OnDisable() {} // 0x00897BE0-0x00897BF0
	public void LoadPrefab() {} // 0x00897BF0-0x00897E20
	public void UnloadPrefab() {} // 0x00897E20-0x00897F70
	private static int HICODE(int x) => default; // 0x00897F80-0x00897F90
	private static int LOCODE(int x) => default; // 0x00897F90-0x00897FA0
	public void SetPriority(int prio) {} // 0x00897FA0-0x00897FB0
	public int GetPriority() => default; // 0x00897FB0-0x00897FC0
	// [IteratorStateMachine] // 0x00630830-0x006308A0
	public IEnumerator Notice(TextId textId, int waitFrame = 1 /* Metadata: 0x00613D22 */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D26 */, int autoCloseFrame = -1 /* Metadata: 0x00613D2A */) => default; // 0x00897FC0-0x00898050
	// [IteratorStateMachine] // 0x006308A0-0x00630910
	public IEnumerator Notice(string pText, int waitFrame = 1 /* Metadata: 0x00613D2E */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D32 */, int autoCloseFrame = -1 /* Metadata: 0x00613D36 */) => default; // 0x00898050-0x008980E0
	// [IteratorStateMachine] // 0x00630910-0x00630980
	public IEnumerator NoticeCommon(TextId textId, int waitFrame = 1 /* Metadata: 0x00613D3A */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D3E */, int autoCloseFrame = -1 /* Metadata: 0x00613D42 */) => default; // 0x008980E0-0x00898170
	// [IteratorStateMachine] // 0x00630980-0x006309F0
	public IEnumerator NoticeRect(TextId textId, RectangleS32 rect, int waitFrame = 1 /* Metadata: 0x00613D46 */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D4A */, bool bLogHistory = true /* Metadata: 0x00613D4E */) => default; // 0x00898170-0x00898220
	// [IteratorStateMachine] // 0x006309F0-0x00630A60
	public IEnumerator NoticeRect(string pText, RectangleS32 rect, int waitFrame = 1 /* Metadata: 0x00613D4F */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D53 */, bool bLogHistory = true /* Metadata: 0x00613D57 */) => default; // 0x00898220-0x008982D0
	// [IteratorStateMachine] // 0x00630A60-0x00630AD0
	public IEnumerator NoticeCommonRect(TextId textId, RectangleS32 rect, int waitFrame = 1 /* Metadata: 0x00613D58 */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D5C */) => default; // 0x008982D0-0x00898370
	// [IteratorStateMachine] // 0x00630AD0-0x00630B40
	public IEnumerator Talk(TextId textId, string pMaster, SystemVoice voice, int waitFrame = 1 /* Metadata: 0x00613D60 */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D64 */, int autoCloseFrame = -1 /* Metadata: 0x00613D68 */) => default; // 0x00898370-0x00898420
	// [IteratorStateMachine] // 0x00630B40-0x00630BB0
	public IEnumerator Talk(string pText, string pMaster, SystemVoice voice, int waitFrame = 1 /* Metadata: 0x00613D6C */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D70 */, int autoCloseFrame = -1 /* Metadata: 0x00613D74 */) => default; // 0x00898420-0x008984D0
	// [IteratorStateMachine] // 0x00630BB0-0x00630C20
	public IEnumerator Log(TextId textId, int waitFrame = 1 /* Metadata: 0x00613D78 */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D7C */) => default; // 0x008984D0-0x00898560
	// [IteratorStateMachine] // 0x00630C20-0x00630C90
	public IEnumerator Log(string pText, int waitFrame = 1 /* Metadata: 0x00613D80 */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D84 */) => default; // 0x00898560-0x008985F0
	// [IteratorStateMachine] // 0x00630C90-0x00630D00
	public IEnumerator Ask(TextId textId, AskParam param, Action<int> resultCb) => default; // 0x008985F0-0x00898680
	private void OnCheckOpenAutoMap() {} // 0x00898680-0x00898690
	private void OnCheckCloseAutoMap() {} // 0x00898690-0x008986A0
	public void Close(bool bAsk = true /* Metadata: 0x00613D88 */) {} // 0x008986A0-0x008987A0
	public void Show(bool bShow) {} // 0x008987A0-0x008987B0
	public void ForceShowCursor() {} // 0x008987B0-0x008987C0
	public bool IsShow() => default; // 0x008987C0-0x008987D0
	private bool IsInput_MessageThrough_() => default; // 0x008987D0-0x008988F0
	// [IteratorStateMachine] // 0x00630D00-0x00630D70
	public IEnumerator KeyWait(int waitTime = -1 /* Metadata: 0x00613D89 */) => default; // 0x008988F0-0x00898970
	// [IteratorStateMachine] // 0x00630D70-0x00630DE0
	private IEnumerator KeyWait_(int waitTime = -1 /* Metadata: 0x00613D8D */) => default; // 0x00898970-0x008989F0
	public void SetKeyWaitMode(KeyWaitMode eKeyWaitMode, int nWaitTime) {} // 0x008989F0-0x00898A00
	public void SetStartKeyWait(int _time = 0 /* Metadata: 0x00613D91 */) {} // 0x00898A00-0x00898A10
	public void SetStringPermeability(int nPermeability = 256 /* Metadata: 0x00613D95 */) {} // 0x00898A10-0x00898AC0
	public void SetScriptMode(bool bEnable) {} // 0x00898AC0-0x00898AD0
	public void SetStartKeyOffWait(bool bStartKeyOffWait) {} // 0x00898AD0-0x00898AE0
	public void SetDecideSESound(bool enable) {} // 0x00898AE0-0x00898AF0
	public void SetSePlay(bool enable) {} // 0x00898AF0-0x00898B00
	public bool IsSePlay() => default; // 0x00898B00-0x00898B10
	public void SetVoice(SystemVoice voice) {} // 0x00898B10-0x00898B20
	public void SetCancelState(CancelState state, bool bMessage) {} // 0x00898B20-0x00898B30
	public void SetLButtonDecideStop(bool _flag) {} // 0x00898B40-0x00898B50
	// [IteratorStateMachine] // 0x00630DE0-0x00630E50
	private IEnumerator Notice_(string pText, RectangleS32 rect, bool isTalk = false /* Metadata: 0x00613D99 */, string pMaster = null, int waitFrame = 1 /* Metadata: 0x00613D9A */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613D9E */, bool bLogHistory = true /* Metadata: 0x00613DA2 */, int autoCloseFrame = -1 /* Metadata: 0x00613DA3 */) => default; // 0x00898B50-0x00898C30
	// [IteratorStateMachine] // 0x00630E50-0x00630EC0
	private IEnumerator Notice__(string pText, RectangleS32 rect, bool isTalk = false /* Metadata: 0x00613DA7 */, string pMaster = null, int waitFrame = 1 /* Metadata: 0x00613DA8 */, NoticeMode mode = NoticeMode.NOTICE_MODE_NONE /* Metadata: 0x00613DAC */, bool bLogHistory = true /* Metadata: 0x00613DB0 */, int autoCloseFrame = -1 /* Metadata: 0x00613DB1 */) => default; // 0x00898C30-0x00898D00
	private RectangleS32 GetNoticeRectangle(RectangleS32 rectBase, NoticeMode mode) => default; // 0x00898D00-0x00898E00
	private bool IsEnableTouch() => default; // 0x00898B30-0x00898B40
	public bool IsAutoPlay() => default; // 0x00898E00-0x00898E10
	public bool IsAutoRegist() => default; // 0x00898E10-0x00898E20
	public int GetTalkAutoCloseFrame() => default; // 0x00898E20-0x00898E30
	public bool SetEnableInputCommandPlayFlag(bool bEnable) => default; // 0x00898E30-0x00898E40
	public bool IsDisableAskSelectRegistFlag() => default; // 0x00898E40-0x00898E50
	public void SetSideNameWindow(bool bRight = false /* Metadata: 0x00613DB5 */) {} // 0x00898E50-0x00898F00
	public void SetPresetPosition(int nPresetNo = 0 /* Metadata: 0x00613DB6 */) {} // 0x00898F00-0x00898FB0
}

