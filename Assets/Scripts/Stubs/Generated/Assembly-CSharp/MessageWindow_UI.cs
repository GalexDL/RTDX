/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using window;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A760-0x0060A770
public class MessageWindow_UI : UIBehaviour // TypeDefIndex: 8096
{
	// Fields
	private static RectangleS32 nameBaseRectA; // 0x00
	private const int wNameOffsetX = 20; // Metadata: 0x00613E5A
	private const int wNameOffsetY = -16; // Metadata: 0x00613E5E
	private const int wNameDrawOffsetX = 20; // Metadata: 0x00613E62
	private const int wNameDrawOffsetY = 5; // Metadata: 0x00613E66
	private Window nameWindow; // 0x18
	private Window messageWindow; // 0x20
	private TextRender nameTextRender; // 0x28
	private TextRender messageTextRender; // 0x30

	// Nested types
	public enum UIMode // TypeDefIndex: 8097
	{
		TALK_WINDOW = 0,
		INFOMATION_WINDOW = 1,
		LOG_WINDOW = 2,
		CENDER_WINDOW = 3
	}

	// Constructors
	public MessageWindow_UI() {} // 0x00E329D0-0x00E329E0
	static MessageWindow_UI() {} // 0x00E329E0-0x00E32A60

	// Methods
	private void sortObj_() {} // 0x00E31870-0x00E31980
	public bool IsOpen() => default; // 0x00E31980-0x00E319F0
	public bool IsNameOpen() => default; // 0x00E319F0-0x00E31A60
	public void Open(RectangleS32 rect, int nPriority, FontType eFontType, bool bOutlineMode, bool bTalkWindow, FrameMode eFrameMode, RectangleS32 clientRect, bool bIsNoFrameMode) {} // 0x00E31A60-0x00E31E50
	public void NameOpen(RectangleS32 rect, int nPriority, bool bTalkWindow, FrameMode eFrameMode, bool bIsNoFrameMode) {} // 0x00E31F20-0x00E32340
	public void Close() {} // 0x00E31E50-0x00E31F20
	public void NameClose() {} // 0x00E32340-0x00E32410
	public void Show(bool bShow) {} // 0x00E32410-0x00E32510
	public bool IsShow() => default; // 0x00E32510-0x00E325B0
	public void ShowPageCursor(bool bShow) {} // 0x00E325B0-0x00E32690
	public void ShowDownCursor(bool bShow) {} // 0x00E32690-0x00E327A0
	public bool IsTouchMessage() => default; // 0x00E327A0-0x00E327B0
	public void SetDrawTextOffset(int x, int y) {} // 0x00E327B0-0x00E327F0
	public int NameDrawText(string text, ColorType color, int limit = -1 /* Metadata: 0x00613E52 */) => default; // 0x00E327F0-0x00E328C0
	public int MessageDrawText(string text, ColorType color, int limit = -1 /* Metadata: 0x00613E56 */) => default; // 0x00E328C0-0x00E32990
	public void NameTextClear() {} // 0x00E32990-0x00E329B0
	public void MessageTextClear() {} // 0x00E329B0-0x00E329D0
}

