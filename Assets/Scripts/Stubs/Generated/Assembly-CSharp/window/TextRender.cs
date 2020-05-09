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
	public class TextRender // TypeDefIndex: 8313
	{
		// Fields
		public const int HSPACE_WIDTH = 4; // Metadata: 0x0061419D
		public const int ZSPACE_WIDTH = 4; // Metadata: 0x006141A1
		public const int HSPACE_BANNER_WIDTH = 8; // Metadata: 0x006141A5
		public const int ZSPACE_BANNER_WIDTH = 8; // Metadata: 0x006141A9
		private static readonly int[] s_aHSpaceWidth; // 0x00
		private static readonly int[] s_aZSpaceWidth; // 0x08
		public const int FONT_WIDTH = 12; // Metadata: 0x006141AD
		public const int FONT_HEIGHT = 12; // Metadata: 0x006141B1
		private const int RUBY_NORMAL_WIDTH = 10; // Metadata: 0x006141B5
		private const int RUBY_NORMAL_HEIGHT = 8; // Metadata: 0x006141B9
		private const int RUBY_BANNER_WIDTH = 12; // Metadata: 0x006141BD
		private const int RUBY_BANNER_HEIGHT = 10; // Metadata: 0x006141C1
		public const int CHAR_WIDTH = 16; // Metadata: 0x006141C5
		public const int CHAR_HEIGHT = 16; // Metadata: 0x006141C9
		public const int MSG_CHAR_WIDTH = 16; // Metadata: 0x006141CD
		public const int MSG_CHAR_HEIGHT = 14; // Metadata: 0x006141D1
		public const int LINE_FEED_PITCH = 16; // Metadata: 0x006141D5
		public const int MSG_LINE_FEED_PITCH = 24; // Metadata: 0x006141D9
		public const int OUTLINE_LINE_FEED_PITCH = 28; // Metadata: 0x006141DD
		public const int HINT_DRAW_Y = 2; // Metadata: 0x006141E1
		public static TextureId[] s_aFontTextureId; // 0x10
		public const int MAX_COLOR_STACK = 16; // Metadata: 0x006141E5
		private List<Primitive_> aPrims_; // 0x10
		private Color32[] aColors; // 0x18
		private Point originPos_; // 0x20
		private RectangleS32 clientRect_; // 0x28
		private Point offset_; // 0x38
		private byte textAlpha_; // 0x40
		private FontType eFontType_; // 0x44
		private FontType eLastFontType_; // 0x48
		private Point lastCharPos_; // 0x4C
		private int m_lineFeedHeight; // 0x54
		private int m_colorStackIndex; // 0x58
		private int[] m_colorStack; // 0x60
		private LinkInfo[] m_aLinkInfo; // 0x68
		private int m_linkInfoCount; // 0x70
		private int m_linkSelectingIndex; // 0x74
		private bool m_bLinkGray; // 0x78
		private string m_pHeadCaptionToScript; // 0x80
		private string m_pHeadCaption; // 0x88
	
		// Properties
		public byte TextAlpha { get => default; set {} } // 0x00B02EB0-0x00B02EC0 0x00B02EC0-0x00B02ED0
		public FontType FontType { get => default; set {} } // 0x00B02ED0-0x00B02EE0 0x00B02EE0-0x00B02EF0
		public Point OriginPos { get => default; set {} } // 0x00B02EF0-0x00B02F00 0x00B02F00-0x00B02F10
		public Point DrawOffset { get => default; set {} } // 0x00B02F10-0x00B02F20 0x00B02F20-0x00B02F30
		public Point LastDrawCharPos { get => default; } // 0x00B02F30-0x00B02F40 
	
		// Nested types
		private enum HSelfType : byte // TypeDefIndex: 8314
		{
			H_SELF_NONE = 0,
			H_SELF_ABILITY = 1,
			H_SELF_DUNGEON_STATUS = 2,
			H_SELF_ITEM = 3,
			H_SELF_ORDER = 4,
			H_SELF_STATUS = 5,
			H_SELF_TEAM_SKILL = 6,
			H_SELF_WAZA = 7,
			H_SELF_SKILL = 8,
			H_SELF_INN = 9
		}
	
		private enum Command_ // TypeDefIndex: 8315
		{
			DRAW_CHAR = 0,
			FACE = 1,
			CLIENT = 2,
			OFFSET = 3,
			FILL = 4,
			MULTI_SELECT = 5,
			COLOR_BOX = 6
		}
	
		private class Primitive_ // TypeDefIndex: 8316
		{
			// Fields
			public Command_ command; // 0x10
			public int x; // 0x14
			public int y; // 0x18
			public int s; // 0x1C
			public int t; // 0x20
			public int w; // 0x24
			public int h; // 0x28
			public TextureId texId; // 0x2C
			public Parameter param; // 0x30
	
			// Nested types
			public struct Parameter // TypeDefIndex: 8317
			{
				// Fields
				public int color; // 0x10
				public bool vf; // 0x14
				public bool hf; // 0x15
			}
	
			// Constructors
			public Primitive_() {} // 0x00B02DD0-0x00B02DE0
		}
	
		private struct LinkInfo // TypeDefIndex: 8318
		{
			// Fields
			public RectangleS32 rect; // 0x10
			public uint index; // 0x20
			public bool bPlural; // 0x24
		}
	
		// Constructors
		public TextRender() {} // 0x00B04FA0-0x00B05060
		static TextRender() {} // 0x00B05060-0x00B05150
	
		// Methods
		private Primitive_[] PushPrimitive_(int size) => default; // 0x00B02CA0-0x00B02DD0
		private static int HICODE(int x) => default; // 0x00B02DE0-0x00B02DF0
		private static int LOCODE(int x) => default; // 0x00B02DF0-0x00B02E00
		public void Clear() {} // 0x00B02E00-0x00B02E60
		public void SetFontType(FontType eFontType) {} // 0x00B02E60-0x00B02E70
		public void SetLastFontType() {} // 0x00B02E70-0x00B02E80
		public FontType GetFontType() => default; // 0x00B02E80-0x00B02E90
		public void SetLineFeedHeight(int height) {} // 0x00B02E90-0x00B02EA0
		public int GetLineFeedHeight() => default; // 0x00B02EA0-0x00B02EB0
		public void SetColors(Color32[] colors) {} // 0x00B02F40-0x00B02F50
		public void SetClipRect(RectangleS32 clientRect) {} // 0x00B02F50-0x00B02F60
		public void ClearClipRect() {} // 0x00B02F60-0x00B02F70
		public void Render(WindowTextRenderer windowTextRender) {} // 0x00B02F70-0x00B03460
		public int DrawText(int x, int y, string pText_, ColorType color, int limit = -1 /* Metadata: 0x00614199 */) => default; // 0x00B03460-0x00B04290
		private void DrawString(ref int x, ref int y, string pszStr, int color) {} // 0x00B04800-0x00B04810
		public void DrawChar(int x, int y, int s, int t, byte[] pPattern, int w, int h, int color) {} // 0x00B046B0-0x00B04800
		public int DrawColorChar(int x, int y, int index, int color) => default; // 0x00B045C0-0x00B046B0
		public void DrawHorizontalLine(int x, int y, int width) {} // 0x00B042A0-0x00B045C0
		public void DrawLinkLine(int x, int y, int width) {} // 0x00B04810-0x00B04890
		public void DrawMultiSelectBox(int x, int y, int w, int h) {} // 0x00B04890-0x00B04910
		public void DrawColorBox(int x, int y, int w, int h, int color, int alpha) {} // 0x00B04910-0x00B04990
		public void DrawMultiSelectNumber(int x, int y, int n) {} // 0x00B04990-0x00B04A20
		public void DrawLinkBox(int x, int y, int width) {} // 0x00B04A20-0x00B04DF0
		public void SetClientRectPrim(RectangleS32 rect) {} // 0x00B04DF0-0x00B04ED0
		public void SetDrawOffsetPrim(int x, int y) {} // 0x00B04ED0-0x00B04F30
		public void SetDrawOffsetPrim(Point offset) {} // 0x00B04F30-0x00B04F90
		public void HideChar(RectangleS32 rect) {} // 0x00B04F90-0x00B04FA0
	}
}
