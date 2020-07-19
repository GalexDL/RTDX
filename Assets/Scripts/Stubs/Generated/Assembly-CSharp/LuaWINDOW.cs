/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using SLua;
using window;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[CustomLuaClass] // 0x00608C80-0x00608C90
public class LuaWINDOW // TypeDefIndex: 4552
{
	// Fields
	private const int MESSAGE_WAIT = 1; // Metadata: 0x006109C3
	private const int KM_SCREEN_A_WIDTH = 720; // Metadata: 0x006109C7
	private const int KM_SCREEN_A_WIDE_WIDTH = 960; // Metadata: 0x006109CB
	private const int KM_SCREEN_A_HEIGHT = 1280; // Metadata: 0x006109CF
	private static RectangleS32 s_outlineCenterRectA; // 0x00
	private static RectangleS32 s_centerRectA; // 0x10
	private static RectangleS32 s_centerRectABottomFrame; // 0x20
	private static RectangleS32 s_chapterCenterRectA; // 0x30
	private static int m_nStringFadeInFrame; // 0x40
	private static int m_nKeyOnTheWayWaitTime; // 0x44
	private static int m_nKeyWaitTime; // 0x48
	private static MessageWindowType m_eMessageWindowType; // 0x4C
	private static bool m_bKeyWait; // 0x50
	private static bool m_bKeyWaitDone; // 0x51
	private static bool m_bKeyWaitLast; // 0x52
	private static bool m_bNextNameOff; // 0x53
	private static UIAskMenu m_uiAskMenu; // 0x58
	private static string m_lastSelect; // 0x60
	private static TagSetLazyBuffer tagBuffer_; // 0x68
	private static bool nowUseTag_; // 0x70
	public static bool NoTagSetBeginEnd; // 0x71

	// Properties
	public static TagSetLazyBuffer LazyTagBuffer { get => default; } // 0x00C01070-0x00C010E0 

	// Nested types
	public class MenuLuaWrapper_AskMenu // TypeDefIndex: 4553
	{
		// Constructors
		public MenuLuaWrapper_AskMenu() {} // 0x00C07230-0x00C07240
	}

	public enum SelectMode // TypeDefIndex: 4554
	{

	}

	public enum MessageWindowType // TypeDefIndex: 4555
	{
		MW_TYPE_NONE = 0,
		MW_TYPE_NORMAL = 1,
		MW_TYPE_TALK = 2,
		MW_TYPE_LOG = 3,
		MW_TYPE_CENTER = 4
	}

	public class ScriptFunc_SymbolWord // TypeDefIndex: 4556
	{
		// Constructors
		public ScriptFunc_SymbolWord() {} // 0x00C07240-0x00C07250
	}

	private class TagSetScope_ : IDisposable // TypeDefIndex: 4557
	{
		// Constructors
		public TagSetScope_() {} // 0x00C02710-0x00C02800

		// Methods
		public void Dispose() {} // 0x00C07250-0x00C07370
	}

	// Constructors
	public LuaWINDOW() {} // 0x00C01E10-0x00C01E20
	static LuaWINDOW() {} // 0x00C01E20-0x00C01FC0

	// Methods
	public static void SetDefaultMessageMode() {} // 0x00BFF620-0x00BFF6A0
	private static bool checkFaceFlip_(int x) => default; // 0x00BFF6A0-0x00BFF6B0
	[IEnumeratorCoroutineYield] // 0x006196E0-0x00619760
	// [IteratorStateMachine] // 0x006196E0-0x00619760
	public static IEnumerator DrawFace(int x, int y, LuaSymAct symAct, FACE_TYPE eFaceType) => default; // 0x00BFF6B0-0x00BFF740
	[IEnumeratorCoroutineYield] // 0x00619760-0x006197E0
	// [IteratorStateMachine] // 0x00619760-0x006197E0
	public static IEnumerator DrawFaceFromPokemonIndex(int x, int y, Index pokemonIndex, bool bFemale, FACE_TYPE eFaceType) => default; // 0x00BFF770-0x00BFF810
	// [IteratorStateMachine] // 0x006197E0-0x00619850
	private static IEnumerator DrawFaceCore_(int x, int y, Index index, bool bFemale, FACE_TYPE eFaceType, bool bFlip) => default; // 0x00BFF840-0x00BFF8F0
	[IEnumeratorCoroutineYield] // 0x00619850-0x006198D0
	// [IteratorStateMachine] // 0x00619850-0x006198D0
	public static IEnumerator DrawFaceF(int x, int y, LuaSymAct symAct, FACE_TYPE eFaceType) => default; // 0x00BFF920-0x00BFF9B0
	public static void ChangeFace(FACE_TYPE eFaceType) {} // 0x00BFF9E0-0x00BFFA60
	[IEnumeratorCoroutineYield] // 0x006198D0-0x00619950
	// [IteratorStateMachine] // 0x006198D0-0x00619950
	public static IEnumerator DrawFaceOffset(int x, int y) => default; // 0x00BFFA60-0x00BFFAE0
	public static void RemoveFace() {} // 0x00BFFB10-0x00BFFC10
	public static void NextNameOff() {} // 0x00BFFC10-0x00BFFC80
	[IEnumeratorCoroutineYield] // 0x0061talk9950-0x006199D0
	// [IteratorStateMachine] // 0x00619950-0x006199D0
	public static IEnumerator CloseMessage() => default; // 0x00BFFC80-0x00BFFCE0
	public static void ForceCloseMessage() {} // 0x00BFFD10-0x00BFFD80
	public static void SetWaitMode(LuaTimeSec timeSec1, LuaTimeSec timeSec2) {} // 0x00BFFF20-0x00C00080
	// [IteratorStateMachine] // 0x006199D0-0x00619A40
	public static IEnumerator SystemLetter(TextID textId) => default; // 0x00C00080-0x00C000F0
	[IEnumeratorCoroutineYield] // 0x00619A40-0x00619AC0
	// [IteratorStateMachine] // 0x00619A40-0x00619AC0
	public static IEnumerator SysMsg(TextID textId) => default; // 0x00C00120-0x00C00190
	// [MonoPInvokeCallback] // 0x00619AC0-0x00619B40
	[StaticExport] // 0x00619AC0-0x00619B40
	public static int SwitchSysMsg(IntPtr l) => default; // 0x00BFF480-0x00BFF5A0
	[IEnumeratorCoroutineYield] // 0x00619B40-0x00619BC0
	// [IteratorStateMachine] // 0x00619B40-0x00619BC0
	public static IEnumerator SysAllMsg(TextID textId) => default; // 0x00C001C0-0x00C00230
	public static void BeginChapter() {} // 0x00C00260-0x00C00270
	public static void EndChapter() {} // 0x00C00270-0x00C00280
	[IEnumeratorCoroutineYield] // 0x00619BC0-0x00619C40
	// [IteratorStateMachine] // 0x00619BC0-0x00619C40
	public static IEnumerator Chapter(LuaTimeSec timeSec1, LuaTimeSec timeSec2, TextID textId) => default; // 0x00C00280-0x00C00300
	[IEnumeratorCoroutineYield] // 0x00619C40-0x00619CC0
	// [IteratorStateMachine] // 0x00619C40-0x00619CC0
	public static IEnumerator Narration(LuaTimeSec timeSec1, LuaTimeSec timeSec2, TextID textId) => default; // 0x00C00330-0x00C003B0
	[IEnumeratorCoroutineYield] // 0x00619CC0-0x00619D40
	// [IteratorStateMachine] // 0x00619CC0-0x00619D40
	public static IEnumerator NarrationBottomFrame(LuaTimeSec timeSec1, LuaTimeSec timeSec2, TextID textId) => default; // 0x00C003E0-0x00C00460
	[IEnumeratorCoroutineYield] // 0x00619D40-0x00619DD0
	// [MonoPInvokeCallback] // 0x00619D40-0x00619DD0
	[StaticExport] // 0x00619D40-0x00619DD0
	public static int SwitchNaration(IntPtr l) => default; // 0x00BFF5A0-0x00BFF620
	[IEnumeratorCoroutineYield] // 0x00619DD0-0x00619E50
	// [IteratorStateMachine] // 0x00619DD0-0x00619E50
	public static IEnumerator NarrationB(LuaTimeSec timeSec1, LuaTimeSec timeSec2, TextID textId) => default; // 0x00C00490-0x00C00510
	[IEnumeratorCoroutineYield] // 0x00619E50-0x00619ED0
	// [IteratorStateMachine] // 0x00619E50-0x00619ED0
	public static IEnumerator Explanation(TextID textId) => default; // 0x00C00540-0x00C005B0
	[IEnumeratorCoroutineYield] // 0x00619ED0-0x00619F50
	// [IteratorStateMachine] // 0x00619ED0-0x00619F50
	public static IEnumerator ExplanationB(TextID textId) => default; // 0x00C005E0-0x00C00650
	[IEnumeratorCoroutineYield] // 0x00619F50-0x00619FD0
	// [IteratorStateMachine] // 0x00619F50-0x00619FD0
	public static IEnumerator Talk(LuaSymAct symAct, TextID textId) => default; // 0x00C00680-0x00C00700
	[IEnumeratorCoroutineYield] // 0x00619FD0-0x0061A050
	// [IteratorStateMachine] // 0x00619FD0-0x0061A050
	public static IEnumerator SwitchTalk(LuaTable talkTbl) => default; // 0x00C00730-0x00C007A0
	[IEnumeratorCoroutineYield] // 0x0061A050-0x0061A0D0
	// [IteratorStateMachine] // 0x0061A050-0x0061A0D0
	public static IEnumerator Monologue(TextID textId) => default; // 0x00C007D0-0x00C00840
	[IEnumeratorCoroutineYield] // 0x0061A0D0-0x0061A150
	// [IteratorStateMachine] // 0x0061A0D0-0x0061A150
	public static IEnumerator Monologue2(TextID textId) => default; // 0x00C00870-0x00C008E0
	[IEnumeratorCoroutineYield] // 0x0061A150-0x0061A1D0
	// [IteratorStateMachine] // 0x0061A150-0x0061A1D0
	public static IEnumerator KeyWait() => default; // 0x00C00910-0x00C00970
	[IEnumeratorCoroutineYield] // 0x0061A1D0-0x0061A250
	// [IteratorStateMachine] // 0x0061A1D0-0x0061A250
	public static IEnumerator KeyWait(int waitTime) => default; // 0x00C009A0-0x00C00A10
	public static void SetStartKeyOffWait(bool bFlag) {} // 0x00C00A40-0x00C00AC0
	[IEnumeratorCoroutineYield] // 0x0061A250-0x0061A2D0
	// [IteratorStateMachine] // 0x0061A250-0x0061A2D0
	public static IEnumerator SelectWithCloseMessage(LuaTable selectTbl) => default; // 0x00C00AC0-0x00C00B30
	[IEnumeratorCoroutineYield] // 0x0061A2D0-0x0061A350
	// [IteratorStateMachine] // 0x0061A2D0-0x0061A350
	public static IEnumerator SelectOrCancelWithCloseMessage(LuaTable selectTbl) => default; // 0x00C00B60-0x00C00BD0
	public static string GetLastSelect() => default; // 0x00BFE7F0-0x00BFE860
	public static void ClearLastSelect() {} // 0x00BFE860-0x00BFE8E0
	public static void SelectChain(TextID textId, int id) {} // 0x00C00C00-0x00C00C10
	public static void DefaultCursor(int id) {} // 0x00C00C10-0x00C00C20
	private static void UpdateKeyWaitSetting_() {} // 0x00C00C20-0x00C00CA0
	private static void ChangeMessageWindowType_(MessageWindowType eMessageWindowType) {} // 0x00C00CA0-0x00C00DE0
	// [IteratorStateMachine] // 0x0061A350-0x0061A3C0
	private static IEnumerator CenterMessage_(int frame0, int frame1, string pText, bool bOutputAll, bool bFontBlackColor, bool bChapterFont, bool bBottomFrame) => default; // 0x00C00DE0-0x00C00EA0
	// [IteratorStateMachine] // 0x0061A3C0-0x0061A430
	public static IEnumerator _Notice(string pText, int waitFrame, bool bSound = true /* Metadata: 0x006109BD */) => default; // 0x00C00ED0-0x00C00F60
	// [IteratorStateMachine] // 0x0061A430-0x0061A4A0
	private static IEnumerator _Talk(string pText, string pMaster, MessageWindow.SystemVoice voice, int waitFrame, bool bHideFrame = false /* Metadata: 0x006109BE */, int autoCloseFrame = -1 /* Metadata: 0x006109BF */) => default; // 0x00C00F90-0x00C01040
	private static void _CloseMessage(bool bRemoveFace) {} // 0x00BFFD80-0x00BFFF20
	public static void TagBegin() {} // 0x00BFE610-0x00BFE6D0
	public static void TagEnd() {} // 0x00BFE6D0-0x00BFE7F0
	public static void Tag_SetDgEndFloor(string dgSymbol) {} // 0x00C010E0-0x00C01440
	public static void Tag_SetJiraachiReward() {} // 0x00C01440-0x00C01710
	public static void Tag_SetGonbeItem() {} // 0x00C01710-0x00C01850
	public static void Tag_SetShopFlow() {} // 0x00C01850-0x00C01950
	public static void Tag_SetPB0_JIRAACHI() {} // 0x00C01950-0x00C01A80
	public static void Tag_SetPB0_DOOBURU() {} // 0x00C01A80-0x00C01BB0
	public static void Tag_SetPB0_KOIRU() {} // 0x00C01BB0-0x00C01CE0
	public static void Tag_SetPB0_SEREBII() {} // 0x00C01CE0-0x00C01E10
}

