/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using window;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIMessageWindow : UIManagerBase // TypeDefIndex: 7105
{
	// Fields
	private UIPrefabLoader pl_; // 0x20
	private UIControlTMP msg_; // 0x28
	private UIControlTMP name_; // 0x30
	private GameObject cursor_; // 0x38
	private const int FLASH_COUNT = 16; // Metadata: 0x006133D3
	private int cursorCounter_; // 0x40
	private bool bShowCursor_; // 0x44
	private Vector3 cursorPagePos_; // 0x48
	private UIMode mode_; // 0x54
	private bool bSideNameWindow_; // 0x58
	private static string[] sPresetPositionTokens; // 0x00

	// Nested types
	public enum UIMode // TypeDefIndex: 7106
	{
		TALK_WINDOW = 0,
		INFORMATION_WINDOW = 1,
		LOG_WINDOW = 2,
		CENTER_WINDOW = 3
	}

	// Constructors
	public UIMessageWindow() {} // 0x00954ED0-0x00954EE0
	static UIMessageWindow() {} // 0x00954EE0-0x00955010

	// Methods
	public void ForceShowCursor() {} // 0x00953390-0x009533A0
	private void Start() {} // 0x009533A0-0x00953610
	private void Update() {} // 0x009539C0-0x00953AA0
	private void _initializeTalk() {} // 0x00953AA0-0x00953C50
	private void _enableTalk(bool bActive) {} // 0x009536E0-0x009537B0
	private void _initializeName() {} // 0x00953C50-0x00953D80
	private void _enableName(bool bActive) {} // 0x00953610-0x009536E0
	private void _initializeNarration() {} // 0x00953D80-0x00953F30
	private void _enableNarration(bool bActive, bool bNoFrame = false /* Metadata: 0x006133CA */) {} // 0x00953880-0x009539C0
	private void _initializeInformation() {} // 0x00953F30-0x009540E0
	private void _enableInformation(bool bActive) {} // 0x009537B0-0x00953880
	public bool IsOpen() => default; // 0x009540E0-0x009541C0
	public bool IsNameOpen() => default; // 0x009541C0-0x00954280
	public void Open(RectangleS32 rect, int nPriority, FontType eFontType, bool bOutlineMode, bool bTalkWindow, FrameMode eFrameMode, RectangleS32 clientRect, bool bIsNoFrameMode) {} // 0x00954280-0x00954310
	public void NameOpen(RectangleS32 rect, int nPriority, bool bTalkWindow, FrameMode eFrameMode, bool bIsNoFrameMode) {} // 0x009544D0-0x009544E0
	public void Close() {} // 0x00954310-0x009544D0
	public void NameClose() {} // 0x009544E0-0x009545A0
	public void Show(bool bShow) {} // 0x009545A0-0x009545B0
	public bool IsShow() => default; // 0x009545B0-0x009545C0
	public void ShowPageCursor(bool bShow) {} // 0x009545C0-0x00954690
	public void ShowDownCursor(bool bShow) {} // 0x00954690-0x00954820
	public bool IsTouchMessage() => default; // 0x00954820-0x00954830
	public void SetDrawTextOffset(int x, int y) {} // 0x00954830-0x00954840
	public int NameDrawText(string text, ColorType color, int limit = -1 /* Metadata: 0x006133CB */) => default; // 0x00954840-0x00954930
	public int MessageDrawText(string text, ColorType color, int limit = -1 /* Metadata: 0x006133CF */) => default; // 0x00954930-0x009549F0
	public void MessageVisibleCharacters(int len) {} // 0x009549F0-0x00954AB0
	public void NameTextClear() {} // 0x00954AB0-0x00954AC0
	public void MessageTextClear() {} // 0x00954AC0-0x00954AD0
	public void SetPermeability(int nPermeability) {} // 0x00954AD0-0x00954BE0
	public void SetSideNameWindow(bool bRight) {} // 0x00954BE0-0x00954C00
	private void _forceSideNameWindow(bool bRight) {} // 0x00954C00-0x00954D30
	public void SetPresetPosition(int nPresetNo) {} // 0x00954D30-0x00954ED0
}

