/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace window
{
	[ExecuteInEditMode] // 0x0060AE10-0x0060AE90
	// [RequireComponent] // 0x0060AE10-0x0060AE90
	public class Window : MonoBehaviour // TypeDefIndex: 8299
	{
		// Fields
		private RectTransform rectTransform_; // 0x18
		public string Caption; // 0x20
		public FontType FontTypeSetting; // 0x28
		public const int DRAW_PRIORITY_BASE = 256; // Metadata: 0x00613F6D
		public const int DRAW_PRIORITY_LIMIT = 0; // Metadata: 0x00613F71
		public const int DRAW_PRIORITY_OFFSET = 8; // Metadata: 0x00613F75
		public const int PRIORITY_AUTO = -1; // Metadata: 0x00613F79
		public const int PRIMITIVE_LARGE_SLOT = 8; // Metadata: 0x00613F7D
		public const int PRIMITIVE_MIDDLE_SLOT = 16; // Metadata: 0x00613F81
		public const int PRIMITIVE_SMALL_SLOT = 32; // Metadata: 0x00613F85
		public const int PRIMITIVE_MICRO_SLOT = 64; // Metadata: 0x00613F89
		public const int MAX_PRIMITIVE_LARGE = 2048; // Metadata: 0x00613F8D
		public const int MAX_PRIMITIVE_MIDDLE = 1024; // Metadata: 0x00613F91
		public const int MAX_PRIMITIVE_SMALL = 512; // Metadata: 0x00613F95
		public const int MAX_PRIMITIVE_MICRO = 256; // Metadata: 0x00613F99
		public const int MAX_PRIMITIVE = 16384; // Metadata: 0x00613F9D
		public const int PRIMITIVE_SLOT_MAX = 64; // Metadata: 0x00613FA1
		public const int PRIMITIVE_BASE_SIZE = 256; // Metadata: 0x00613FA5
		public const ulong ATTR_VALID = 1; // Metadata: 0x00613FA9
		public const ulong ATTR_HIDE = 2; // Metadata: 0x00613FB1
		public const ulong ATTR_FRAME = 4; // Metadata: 0x00613FB9
		public const ulong ATTR_DRAW_OKAY = 16; // Metadata: 0x00613FC1
		public const ulong ATTR_DRAW_CLOSE = 32; // Metadata: 0x00613FC9
		public const ulong ATTR_DRAW_LEFT_PAGE = 64; // Metadata: 0x00613FD1
		public const ulong ATTR_DRAW_RIGHT_PAGE = 128; // Metadata: 0x00613FD9
		public const ulong ATTR_DRAW_CURSOR_UP = 256; // Metadata: 0x00613FE1
		public const ulong ATTR_DRAW_CURSOR_DOWN = 512; // Metadata: 0x00613FE9
		public const ulong ATTR_DRAW_CURSOR = 1024; // Metadata: 0x00613FF1
		public const ulong ATTR_DRAW_CURSOR_PAGE = 4096; // Metadata: 0x00613FF9
		public const ulong ATTR_DRAW_DARK_CURSOR = 8192; // Metadata: 0x00614001
		public const ulong ATTR_VALID_OKAY = 16384; // Metadata: 0x00614009
		public const ulong ATTR_TOUCH_WINDOW = 32768; // Metadata: 0x00614011
		public const ulong ATTR_DRAW_GROUND = 65536; // Metadata: 0x00614019
		public const ulong ATTR_CLIP = 131072; // Metadata: 0x00614021
		public const ulong ATTR_DRAW_UP_PAGE = 524288; // Metadata: 0x00614029
		public const ulong ATTR_DRAW_DOWN_PAGE = 1048576; // Metadata: 0x00614031
		public const ulong ATTR_FLASH = 2097152; // Metadata: 0x00614039
		public const ulong ATTR_DRAW_SORT = 8388608; // Metadata: 0x00614041
		public const ulong ATTR_ICON = 16777216; // Metadata: 0x00614049
		public const ulong ATTR_CAN_TOUCH = 33554432; // Metadata: 0x00614051
		public const ulong ATTR_OPTION = 67108864; // Metadata: 0x00614059
		public const ulong ATTR_DRAW_LEFT_PAGE_SKIP = 134217728; // Metadata: 0x00614061
		public const ulong ATTR_DRAW_RIGHT_PAGE_SKIP = 268435456; // Metadata: 0x00614069
		public const ulong ATTR_DRAW_FORCE_HEADER_HLINE = 2147483648; // Metadata: 0x00614071
		public const ulong ATTR_DRAW_FORCE_FOOTER_HLINE = 4294967296; // Metadata: 0x00614079
		public const ulong ATTR_DRAW_HEAD_PAGE_NUM = 8589934592; // Metadata: 0x00614081
		public const ulong ATTR_HIGH_LIGHT_FLASH = 17179869184; // Metadata: 0x00614089
		public const ulong ATTR_DRAW_FOOTER = 2149056752; // Metadata: 0x00614091
		public const ulong ATTR_DRAW_HEADER = 12884901888; // Metadata: 0x00614099
		public const int MAX_SELECT_POS = 128; // Metadata: 0x006140A1
		public const int MAX_LINK_INFO = 16; // Metadata: 0x006140A5
		private static Color32[] s_aUniqueColors; // 0x00
		private static Color32[][] s_aColorsArrayFromFrame; // 0x08
		private static Color32[] s_aGroundColors; // 0x10
		private static Color32 s_TouchGroundColor; // 0x18
		private static Color32[] s_aTouchGroundColors; // 0x20
		private const int FLASH_COUNT = 16; // Metadata: 0x006140A9
		private static char[] color_chars; // 0x28
		private static char[] unique_color_chars; // 0x30
		private static readonly RectangleS32[] s_TalkMenuFrameUV; // 0x38
		private static readonly RectangleS32[] s_InfoMenuFrameUV; // 0x40
		private static readonly Point[] s_aFrameOffsetUV; // 0x48
		private static readonly Point[] s_aMenuFrameOffsetUV; // 0x50
		private static readonly RectangleS32[] s_aFrame16_8UV; // 0x58
		private static readonly RectangleS32[] s_aFaceFrameUV; // 0x60
		private static readonly RectangleS32[] s_aFaceFrameUV2; // 0x68
		private static readonly RectangleS32[] s_aLogFrameUV; // 0x70
		private static FrameParameter[] s_apFrameUV8_8; // 0x78
		private static FrameParameter[] s_apFrameUV16_8; // 0x80
		private static readonly RectangleS32[] s_aFrameGroundUV; // 0x88
		private static readonly Point[] s_aFrameGroundOffsetUV; // 0x90
		private static readonly Point[] s_aMenuGroundOffsetUV; // 0x98
		private static readonly RectangleS32[] s_aInformationFrameGroundUV; // 0xA0
		private static readonly RectangleS32[] s_NarationGroundUV; // 0xA8
		private static readonly RectangleS32[] s_TalkMenuGroundUV; // 0xB0
		private static FrameGroundParameter[] s_apFrameGroundUV; // 0xB8
		private static readonly RectangleS32[] s_aIconToCodeTable; // 0xC0
		private const ColorType DEFAULT_INFO_MENU_TEXT_COLOR = ColorType.COLOR_WHITE; // Metadata: 0x006140AD
		private const ColorType DEFAULT_TALK_MENU_TEXT_COLOR = ColorType.COLOR_BLACK; // Metadata: 0x006140B1
		private const ColorType DEFAULT_FRAME_MENU_TEXT_COLOR = ColorType.COLOR_BLACK; // Metadata: 0x006140B5
		public const int MAX_CAPTION_CHAR = 64; // Metadata: 0x006140B9
		public const int DEFAULT_CLIENT_OFS_W = 0; // Metadata: 0x006140BD
		public const int DEFAULT_CLIENT_OFS_H = 0; // Metadata: 0x006140C1
		public const int DEFAULT_CURSOR_SIZE_W = 8; // Metadata: 0x006140C5
		public const int HEADER_LINE_HEIGHT = 0; // Metadata: 0x006140C9
		public const int FOOTER_LINE_HEIGHT = 8; // Metadata: 0x006140CD
		public const int HEADER_HEIGHT = 16; // Metadata: 0x006140D1
		public const int FOOTER_HEIGHT = 24; // Metadata: 0x006140D5
		public const int MAX_COLOR_CHAR = 118; // Metadata: 0x006140D9
		public const int MAX_CLEAR_ICON = 84; // Metadata: 0x006140DD
		public const int MAX_OPTION = 10; // Metadata: 0x006140E1
		public const int ICON_COUNT = 8; // Metadata: 0x006140E5
		public const int TOUCH_RECT_COUNT = 10; // Metadata: 0x006140E9
		public const int TOUCH_AUTO_FIRST_COUNT = 35; // Metadata: 0x006140ED
		public const int TOUCH_AUTO_REPEAT_COUNT = 8; // Metadata: 0x006140F1
		public const int TOUCH_AUTO_REPEAT_COUNT_SLOW = 8; // Metadata: 0x006140F5
		public const int HIGH_LIGHT_FLASH_COUNT = 2; // Metadata: 0x006140F9
		private int m_alpha; // 0x2C
		private int m_nPermeability; // 0x30
		private int m_primCount; // 0x34
		private int m_frameCount; // 0x38
		private int m_closeCount; // 0x3C
		private int m_leftPageCount; // 0x40
		private int m_rightPageCount; // 0x44
		private int m_downPageCount; // 0x48
		private int m_upPageCount; // 0x4C
		private int m_leftPageSkipCount; // 0x50
		private int m_rightPageSkipCount; // 0x54
		private int m_upPageSkipCount; // 0x58
		private int m_downPageSkipCount; // 0x5C
		private int m_upCursorCount; // 0x60
		private int m_downCursorCount; // 0x64
		private int m_okayCount; // 0x68
		private int m_sortCount; // 0x6C
		private int m_coutionCount; // 0x70
		private int m_selectCount; // 0x74
		private int m_linkCount; // 0x78
		private int m_windowCount; // 0x7C
		private int m_selectRectCount; // 0x80
		private int[] m_selectRectIndex; // 0x88
		private int[] m_selectLinkIndex; // 0x90
		private int m_optionCnt; // 0x98
		private CursorType m_cursorType; // 0x9C
		private Size m_cursorSize; // 0xA0
		private IconSpriteInfo DRAW_OKAY; // 0xA8
		private IconSpriteInfo DRAW_CLOSE; // 0xB0
		private IconSpriteInfo DRAW_LEFT_PAGE; // 0xB8
		private IconSpriteInfo DRAW_RIGHT_PAGE; // 0xC0
		private IconSpriteInfo DRAW_CURSOR_UP; // 0xC8
		private IconSpriteInfo DRAW_CURSOR_DOWN; // 0xD0
		private IconSpriteInfo DRAW_CURSOR; // 0xD8
		private IconSpriteInfo DRAW_CURSOR_PAGE; // 0xE0
		private IconSpriteInfo DRAW_DARK_CURSOR; // 0xE8
		private IconSpriteInfo DRAW_UP_PAGE; // 0xF0
		private IconSpriteInfo DRAW_DOWN_PAGE; // 0xF8
		private IconSpriteInfo DRAW_SORT; // 0x100
		private IconSpriteInfo DRAW_LEFT_PAGE_SKIP; // 0x108
		private IconSpriteInfo DRAW_RIGHT_PAGE_SKIP; // 0x110
		private Point m_cursorPos; // 0x118
		private Point m_cursorDownPos; // 0x120
		private Point m_cursorUpPos; // 0x128
		private Point m_pageLeftPos; // 0x130
		private Point m_pageRightPos; // 0x138
		private Point m_pageDownPos; // 0x140
		private Point m_pageUpPos; // 0x148
		private Point[] m_optionRightPos; // 0x150
		private Point[] m_optionLeftPos; // 0x158
		private RectangleS32[] m_aSelectRect; // 0x160
		private string m_szCaption; // 0x168
		private short m_primSlot; // 0x170
		private short m_primSize; // 0x172
		private WindowTextRenderer m_windowTextRender; // 0x178
		private bool m_bFloor; // 0x180
		private bool m_bFrontPriorityMode; // 0x181
		private bool m_bTouchClose; // 0x182
		private bool m_bTouchOkay; // 0x183
		private bool m_bTouchSort; // 0x184
		private bool m_bTouchLeftPage; // 0x185
		private bool m_bTouchRightPage; // 0x186
		private bool m_bTouchDownPage; // 0x187
		private bool m_bTouchUpPage; // 0x188
		private bool m_bTouchLeftPageSkip; // 0x189
		private bool m_bTouchRightPageSkip; // 0x18A
		private bool m_bTouchUpPageSkip; // 0x18B
		private bool m_bTouchDownPageSkip; // 0x18C
		private bool m_bTouchUpCursor; // 0x18D
		private bool m_bTouchDownCursor; // 0x18E
		private bool m_bTouchWindow; // 0x18F
		private bool m_bTouchWindowContinue; // 0x190
		private bool m_bTouchTempEnable; // 0x191
		private bool m_bTouchDownPageAuto; // 0x192
		private bool m_bTouchUpPageAuto; // 0x193
		private bool m_bTouchDownCursorAuto; // 0x194
		private bool m_bTouchUpCursorAuto; // 0x195
		private int m_bTouchDownPageAutoCount; // 0x198
		private int m_bTouchUpPageAutoCount; // 0x19C
		private int m_bTouchDownCursorAutoCount; // 0x1A0
		private int m_bTouchUpCursorAutoCount; // 0x1A4
		private bool m_bUpdate; // 0x1A8
		private bool m_bEnablePageLeftPos; // 0x1A9
		private bool m_bEnablePageRightPos; // 0x1AA
		private bool m_bEnablePageDownPos; // 0x1AB
		private bool m_bEnablePageUpPos; // 0x1AC
		private ColorEffect m_eColorEffect; // 0x1B0
		private ColorType m_eColorType; // 0x1B4
		private int m_nHighLightFlashCount; // 0x1B8
		private int m_selectCountIcon; // 0x1BC
		private int m_selectDrawIndex; // 0x1C0
		private int m_pageNumIdx; // 0x1C4
		private int m_pageNumMax; // 0x1C8
		private BtnInfo[] m_btnInfo; // 0x1D0
		private bool m_bPageLine; // 0x1D8
		private ulong m_attr; // 0x1E0
		private FrameMode m_eFrameMode; // 0x1E8
		private int m_nPriority; // 0x1EC
		private int m_nDrawPriority; // 0x1F0
		private int m_nForceDrawCurosrPriority; // 0x1F4
		private int[] m_aPageIndex; // 0x1F8
		private int m_captionIndex; // 0x200
		private int m_nFrameAndGroundAlpha; // 0x204
		private RectangleS32 m_windowRect; // 0x208
		private RectangleS32 m_clientRect; // 0x218
		private TextReferenceType m_eTextReferenceType; // 0x228
		private FontType m_eFontType; // 0x22C
		private FontType m_eLastFontType; // 0x230
		private int m_pageActType; // 0x234
		private int m_pageActTime; // 0x238
		private float m_fParallax; // 0x23C
		private TextRender m_mainTextRender; // 0x240
		private List<TextRender> m_textRenderList; // 0x248
		private string m_pHeadCaptionToScript; // 0x250
		private string m_pHeadCaption; // 0x258
	
		// Nested types
		public enum TextReferenceType // TypeDefIndex: 8300
		{
			TEXT_REF_TYPE_0 = 0,
			TEXT_REF_TYPE_MAX = 1,
			TEXT_REF_TYPE_NONE = 1
		}
	
		public enum ColorEffect // TypeDefIndex: 8301
		{
			CE_NONE = 0,
			CE_LOWLIGHT = 1,
			CE_HIGHLIGHT = 2,
			CE_MAX = 3
		}
	
		private class FrameParameter // TypeDefIndex: 8302
		{
			// Fields
			public RectangleS32[] pRect; // 0x10
			public Point uvOffset; // 0x18
			public int nFramePriority; // 0x20
			public int nFrameBottomPriority; // 0x24
			public int nOffsetWH; // 0x28
	
			// Constructors
			public FrameParameter() {} // 0x01621CF0-0x01621D00
		}
	
		private struct FrameGroundParameter // TypeDefIndex: 8303
		{
			// Fields
			public RectangleS32[] pRect; // 0x10
			public Point uvOffset; // 0x18
			public int nPriority; // 0x20
			public int nOffsetWH; // 0x24
		}
	
		private enum UniqueColorType // TypeDefIndex: 8304
		{
			UNIQUE_COLOR_TYPE_0 = 0,
			UNIQUE_COLOR_TYPE_1 = 1,
			UNIQUE_COLOR_TYPE_2 = 2,
			UNIQUE_COLOR_TYPE_3 = 3,
			UNIQUE_COLOR_TYPE_MAX = 4
		}
	
		public enum CursorType // TypeDefIndex: 8305
		{
			CURSOR_TYPE_NORMAL = 0,
			CURSOR_TYPE_NORMAL_ANIMATION = 1
		}
	
		private struct ControlCode // TypeDefIndex: 8306
		{
			// Fields
			private string pText; // 0x10
			private char code; // 0x18
			private ushort flags; // 0x1A
			private ushort count; // 0x1C
			private ushort width; // 0x1E
		}
	
		public enum IconType // TypeDefIndex: 8307
		{
			ICON_SORT = 0,
			ICON_UP_PAGE = 1,
			ICON_DOWN_PAGE = 2,
			ICON_LEFT_PAGE = 3,
			ICON_RIGHT_PAGE = 4,
			ICON_RIGHT_PAGE_SKIP = 5,
			ICON_LEFT_PAGE_SKIP = 6,
			ICON_MINUS = 7,
			ICON_OKAY = 8,
			ICON_CLOSE = 9,
			ICON_FIND = 10,
			ICON_CURSOR_0 = 11,
			ICON_CURSOR_1 = 12,
			ICON_CURSOR_2 = 13,
			ICON_CURSOR_3 = 14,
			ICON_CURSOR_DOWN = 15,
			ICON_CURSOR_UP = 16,
			ICON_CURSOR_LEFT = 17,
			ICON_CURSOR_RIGHT = 18,
			ICON_BTN_L = 19,
			ICON_BTN_R = 20,
			ICON_MAX = 21
		}
	
		public enum ButtonType // TypeDefIndex: 8308
		{
			BTN_PAGE_NUM_L = 0,
			BTN_PAGE_NUM_R = 1,
			BTN_MAX = 2
		}
	
		private class IconSpriteInfo // TypeDefIndex: 8309
		{
			// Fields
			public bool bDisp; // 0x10
			public IconType iconType; // 0x14
			public bool bShow; // 0x18
			public bool bTouch; // 0x19
			public bool bEnableTouchAutoRep; // 0x1A
			public int touchAutoCount; // 0x1C
			public bool bOverridePos; // 0x20
			public Point overridePos; // 0x24
			public int animCount; // 0x2C
	
			// Properties
			public RectangleS32 rect { get => default; } // 0x01621D00-0x01621DA0 
	
			// Constructors
			public IconSpriteInfo() {} // 0x01621DA0-0x01621DB0
		}
	
		private struct BtnInfo // TypeDefIndex: 8310
		{
			// Fields
			public bool bTouch; // 0x10
			public int nTouchCnt; // 0x14
	
			// Methods
			private void Init() {} // 0x01621C10-0x01621CF0
		}
	
		// Constructors
		public Window() {} // 0x00B0AB70-0x00B0AE70
		static Window() {} // 0x00B0AE70-0x00B0E5F0
	
		// Methods
		private void OnEnable() {} // 0x00B053A0-0x00B054B0
		private void OnDisable() {} // 0x00B05A80-0x00B05A90
		private void OnDestroy() {} // 0x00B05A90-0x00B05AA0
		private Rect calcRectTransformLocalRect_() => default; // 0x00B054B0-0x00B05590
		private void Update() {} // 0x00B05AA0-0x00B05BA0
		public TextRender AddTextRender() => default; // 0x00B08DC0-0x00B08E40
		public void RemoveTextRender(TextRender textRender) {} // 0x00B08E40-0x00B08EA0
		public void Initalize(RectangleS32 rect, int nTaslPriority) {} // 0x00B05590-0x00B05890
		protected static void SetFGVariation(FrameAndGroundVariation eFrameAndGroundVariation) {} // 0x00B05890-0x00B05A80
		protected static void SetIFGVariation(InfomationFrameAndGroundVariation eFrameAndGroundVariation) {} // 0x00B08EC0-0x00B08FF0
		public void AutoWindowAndClientResize(Size needClientSize, int clientOffsW = 0 /* Metadata: 0x00613F59 */, int clientOffsH = 0 /* Metadata: 0x00613F5D */) {} // 0x00B08FF0-0x00B09200
		public void SetClientRect(RectangleS32 rect) {} // 0x00B094C0-0x00B09570
		public void SetPosition(int x, int y) {} // 0x00B09570-0x00B09580
		public void SetPosition(Point pos) {} // 0x00B09580-0x00B09590
		public void SetWindowSize(Size size) {} // 0x00B09410-0x00B094C0
		public Point GetPosition() => default; // 0x00B09590-0x00B095A0
		public RectangleS32 GetWindowRect() => default; // 0x00B095A0-0x00B095B0
		public RectangleS32 GetClientRect() => default; // 0x00B095B0-0x00B095C0
		public bool IsValid() => default; // 0x00B095C0-0x00B095D0
		public TextRender GetMainTextRender() => default; // 0x00B05D20-0x00B05D30
		private static ColorType GetColorCode(char c) => default; // 0x00B095D0-0x00B09680
		private static void SetUniqueColor(int nSlot, byte r, byte g, byte b) {} // 0x00B09680-0x00B09760
		private static Color32 GetUniqueColor(int nSlot) => default; // 0x00B09760-0x00B09800
		public static ColorType GetDefaultTextColor(FrameMode eFrameMode, bool bForceTalkColor = false /* Metadata: 0x00613F61 */) => default; // 0x00B09800-0x00B09840
		public void DrawPageIcon(int x, int y, IconType type, bool bDown = false /* Metadata: 0x00613F62 */) {} // 0x00B09840-0x00B09A00
		public bool IsTouchPageIcon(int x, int y, IconType type) => default; // 0x00B09A00-0x00B09A90
		public void Clear() {} // 0x00B09A90-0x00B09B00
		public void Show(bool bShow) {} // 0x00B09B00-0x00B09B20
		public bool IsShow() => default; // 0x00B09B20-0x00B09B30
		public void SetPriority(int priority) {} // 0x00B09B30-0x00B09B60
		public void SetDrawPriority(int priority) {} // 0x00B09B60-0x00B09B70
		public void SetForceDrawCursorPriority(int priority) {} // 0x00B09B70-0x00B09B80
		public void SetDrawPirorityFrontMode(bool bEnable) {} // 0x00B09B80-0x00B09B90
		public void SetCaption(string pszCaption) {} // 0x00B05BA0-0x00B05D20
		public void SetPermeability(int nPermeability) {} // 0x00B09B90-0x00B09C20
		public void ShowGround(bool bShow) {} // 0x00B09C20-0x00B09C40
		public void ShowFrame(bool bShow) {} // 0x00B09C40-0x00B09C60
		public void ShowIcon(bool bShow) {} // 0x00B09C60-0x00B09C80
		public void ShowOkayIcon(bool bShow) {} // 0x00B09C80-0x00B09CA0
		public void ValidOkayIcon(bool bValid) {} // 0x00B09CA0-0x00B09CC0
		public void ShowCloseIcon(bool bShow) {} // 0x00B09CC0-0x00B09CE0
		public void ShowSortIcon(bool bShow) {} // 0x00B09CE0-0x00B09D00
		public void ShowLeftPageIcon(bool bShow) {} // 0x00B09D00-0x00B09D20
		public void ShowRightPageIcon(bool bShow) {} // 0x00B09D20-0x00B09D40
		public void SetLeftPageIconPosition(int x, int y) {} // 0x00B09D40-0x00B09D60
		public void SetRightPageIconPosition(int x, int y) {} // 0x00B09D60-0x00B09D80
		public void ShowDownPageIcon(bool bShow) {} // 0x00B09D80-0x00B09DA0
		public void ShowUpPageIcon(bool bShow) {} // 0x00B09DA0-0x00B09DC0
		public void SetDownPageIconPosition(int x, int y) {} // 0x00B09DC0-0x00B09DE0
		public void SetUpPageIconPosition(int x, int y) {} // 0x00B09DE0-0x00B09E00
		public void ShowLeftPageSkipIcon(bool bShow) {} // 0x00B09E00-0x00B09E20
		public void ShowRightPageSkipIcon(bool bShow) {} // 0x00B09E20-0x00B09E40
		public void ShowDownCursor(bool bShow) {} // 0x00B09E40-0x00B09E60
		public void SetDownCursorPosition(int x, int y) {} // 0x00B09E60-0x00B09E70
		public void SetDownCursorPosition(Point pos) {} // 0x00B09E70-0x00B09E80
		public void ShowUpCursor(bool bShow) {} // 0x00B09E80-0x00B09EA0
		public void ShowOptionCursor(bool bShow) {} // 0x00B09EA0-0x00B09EC0
		public void SetUpCursorPosition(int x, int y) {} // 0x00B09EC0-0x00B09ED0
		public void SetUpCursorPosition(Point pos) {} // 0x00B09ED0-0x00B09EE0
		public void ShowPageCursor(bool bShow) {} // 0x00B09EE0-0x00B09F00
		public void AddSelectRectangle(RectangleS32 rect) {} // 0x00B09F00-0x00B09F60
		public void ClearSelectRectangle() {} // 0x00B09F60-0x00B09F70
		public string GetHeadCaptionToScript() => default; // 0x00B09F70-0x00B09F80
		public string GetHeadCaption() => default; // 0x00B09F80-0x00B09F90
		public void ResetFrameCount() {} // 0x00B09F90-0x00B09FA0
		public void SetCursorPosition(int x, int y) {} // 0x00B09FA0-0x00B09FB0
		public void SetCursorPosition(Point pos) {} // 0x00B09FB0-0x00B09FC0
		public void SetCursorSize(Size size) {} // 0x00B09FC0-0x00B09FD0
		public void ShowCursor(bool bShow) {} // 0x00B09FD0-0x00B09FF0
		public bool IsShowCursor() => default; // 0x00B09FF0-0x00B0A000
		public void SetCursorType(CursorType type) {} // 0x00B0A000-0x00B0A010
		public void SetCursorDark(bool bDark) {} // 0x00B0A010-0x00B0A030
		public void EnableTouch(bool bEnable) {} // 0x00B0A030-0x00B0A050
		public void EnableTouchAll(bool bEnable) {} // 0x00B0A050-0x00B0A070
		public void EnableTempTouch(bool bEnable) {} // 0x00B0A070-0x00B0A080
		public void SetFlash(bool bFlash) {} // 0x00B0A080-0x00B0A0A0
		public void DisableFooter() {} // 0x00B0A0A0-0x00B0A0C0
		public void EnableClip() {} // 0x00B0A0C0-0x00B0A0D0
		public void DisableClip() {} // 0x00B0A0D0-0x00B0A0E0
		public void SetFrameMode(FrameMode eMode) {} // 0x00B0A0E0-0x00B0A100
		public FrameMode GetFrameMode() => default; // 0x00B0A110-0x00B0A120
		public void SetOptionCnt(int optionCnt) {} // 0x00B0A120-0x00B0A140
		public void SetOptionRightCursor(int index, Point pos) {} // 0x00B0A140-0x00B0A190
		public void SetOptionLeftCursor(int index, Point pos) {} // 0x00B0A190-0x00B0A1E0
		public void ShowForceFooterLine(bool bShow) {} // 0x00B0A1E0-0x00B0A200
		private bool IsTouchClose() => default; // 0x00B0A200-0x00B0A210
		private bool IsTouchOkay() => default; // 0x00B0A210-0x00B0A220
		private bool IsTouchSort() => default; // 0x00B0A220-0x00B0A230
		private bool IsTouchLeftPage() => default; // 0x00B0A230-0x00B0A240
		private bool IsTouchRightPage() => default; // 0x00B0A240-0x00B0A250
		private bool IsTouchDownPage() => default; // 0x00B0A250-0x00B0A260
		private bool IsTouchDownPageAuto() => default; // 0x00B0A260-0x00B0A270
		private bool IsTouchUpPage() => default; // 0x00B0A270-0x00B0A280
		private bool IsTouchUpPageAuto() => default; // 0x00B0A280-0x00B0A290
		private bool IsTouchLeftPageSkip() => default; // 0x00B0A290-0x00B0A2A0
		private bool IsTouchRightPageSkip() => default; // 0x00B0A2A0-0x00B0A2B0
		private bool IsTouchUpPageSkip() => default; // 0x00B0A2B0-0x00B0A2C0
		private bool IsTouchDownPageSkip() => default; // 0x00B0A2C0-0x00B0A2D0
		private bool IsTouchUpCursor() => default; // 0x00B0A2D0-0x00B0A2E0
		private bool IsTouchDownCursor() => default; // 0x00B0A2E0-0x00B0A2F0
		private bool IsTouchUpCursorAuto() => default; // 0x00B0A2F0-0x00B0A300
		private bool IsTouchDownCursorAuto() => default; // 0x00B0A300-0x00B0A310
		private bool IsTouchWindow() => default; // 0x00B0A310-0x00B0A320
		private bool IsTouchWindowContinue() => default; // 0x00B0A320-0x00B0A330
		private int GetSelectRectIndex() => default; // 0x00B0A330-0x00B0A380
		private int GetSelectDrawRectIndex() => default; // 0x00B0A380-0x00B0A3C0
		private void ClearSelectRectIndex() {} // 0x00B0A3C0-0x00B0A440
		private int GetSelectLinkIndex() => default; // 0x00B0A440-0x00B0A490
		public int GetSelectCnt() => default; // 0x00B0A490-0x00B0A4A0
		public bool IsTouchDelay() => default; // 0x00B0A4A0-0x00B0A5A0
		public void SetColorEffect(ColorEffect eColorEffect) {} // 0x00B0A5A0-0x00B0A5B0
		public void SetHighLightFlash(bool bEnable) {} // 0x00B0A5B0-0x00B0A5E0
		public void SelectGroundColorType(ColorType eColorType) {} // 0x00B0A100-0x00B0A110
		public void SetFrameAndGroundAlpha(int nAlpha) {} // 0x00B0A5E0-0x00B0A670
		public int GetFrameAndGroundAlpha() => default; // 0x00B0A670-0x00B0A680
		public void ShowPageLine(bool bShow) {} // 0x00B0A680-0x00B0A690
		public void ShowPageNum(bool bShow) {} // 0x00B0A690-0x00B0A6B0
		public void SetPageNum(int pageNow, int pageMax) {} // 0x00B0A6B0-0x00B0A6C0
		public bool IsTouchButton(ButtonType type) => default; // 0x00B0A6C0-0x00B0A710
		public static Color32 GetColorNormal(ColorType color) => default; // 0x00B0A710-0x00B0A7B0
		public void WindowUpdate() {} // 0x00B05D30-0x00B05D70
		public void WindowDraw() {} // 0x00B05D70-0x00B08DC0
		public int GetDrawPriority() => default; // 0x00B0A980-0x00B0A990
		public int GetDrawCursorPriority() => default; // 0x00B0A990-0x00B0A9A0
		public int GetDrawGroundPriority() => default; // 0x00B0A9A0-0x00B0A9B0
		public void FillRect(int x, int y, int w, int h, Color32 color, int nPriority) {} // 0x00B0A9B0-0x00B0A9C0
		public void DrawRect(TextureId texId, int x, int y, int s, int t, int w, int h, Color32 color, int nPriority, bool vf = false /* Metadata: 0x00613F63 */, bool hf = false /* Metadata: 0x00613F64 */) {} // 0x00B0A8F0-0x00B0A930
		public void DrawRectZoom(TextureId texId, int x, int y, int w, int h, int s, int t, int sw, int th, Color32 color, int nPriority) {} // 0x00B0A930-0x00B0A980
		public int GetTaskPriority() => default; // 0x00B0A9C0-0x00B0A9D0
		private void DrawIcon_(IconType iconType, int x, int y, int offsU, int offsV, bool bDark) {} // 0x00B0A9D0-0x00B0AB60
		private void CheckBtnTouch_(ButtonType btnType, int x, int y, int w, int h) {} // 0x00B0AB60-0x00B0AB70
		private int CalcPageNumWidth_() => default; // 0x00B09200-0x00B09410
		private void SetDrawPriorityFromTaskPriority(int priority) {} // 0x00B08EA0-0x00B08EC0
		private void UpdateDrawIconInfo_(IconSpriteInfo info, bool bDraw, int x_, int y_, Color32[] aColors, int uvSlideNumS = 0 /* Metadata: 0x00613F65 */, int uvSlideNumT = 0 /* Metadata: 0x00613F69 */) {} // 0x00B0A7B0-0x00B0A8F0
	}
}
