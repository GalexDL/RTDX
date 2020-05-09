/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SpecialAnim;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UILinkFocus : UIManagerBase // TypeDefIndex: 7041
{
	// Fields
	private bool enable; // 0x1C
	private GameObject mainObj_; // 0x20
	private GameObject focusObj_; // 0x28
	private UIControlTMP nowTmp_; // 0x30
	private List<UIControlTMP> tmpList_; // 0x38
	private int tmpListCount; // 0x40
	private string[] actionName_; // 0x48
	private Anim<ViewState> anim; // 0x50
	private int linkCount_; // 0x58
	private Action closeCb_; // 0x60
	private Action<uint> decideCb_; // 0x68

	// Nested types
	public struct LinkFocusData // TypeDefIndex: 7042
	{
		// Fields
		public Vector2 pos; // 0x10
		public Vector2 size; // 0x18
	}

	public enum ViewState // TypeDefIndex: 7043
	{
		NONE = 0,
		OPENFOCUS = 1,
		CLOSEFOCUS = 2
	}

	// Constructors
	private UILinkFocus() {} // 0x00942F90-0x00943130

	// Methods
	public static UILinkFocus Create() => default; // 0x00943130-0x00943310
	private void RectReset() {} // 0x00943310-0x009433A0
	public void OpenFocus(UIControlTMP tmp, Action cb = null) {} // 0x009433A0-0x009433B0
	public void OpenFocus(UIControlTMP tmp, List<UIControlTMP> tmpList, Action cb = null) {} // 0x00943550-0x00943560
	private void OpenFocusBase(UIControlTMP tmp, Action cb = null) {} // 0x009433B0-0x00943550
	public void ChangeTMP(UIControlTMP tmp) {} // 0x009437C0-0x009437D0
	public void CloseFocus() {} // 0x009437D0-0x00943950
	public void CloseFocus_Decide(uint u) {} // 0x00943960-0x00943AB0
	public bool SetFocus(int index) => default; // 0x00943580-0x009437C0
	public void doUpdate_() {} // 0x00943AC0-0x00943AD0
	private void _doInput() {} // 0x00943AD0-0x00943C90
	private void ResetLinkCount() {} // 0x00943570-0x00943580
	private bool _doDecide() => default; // 0x00943C90-0x00943D30
	private bool _doCancel() => default; // 0x00943D30-0x00943D50
	private bool _doStart() => default; // 0x00943D50-0x00943D90
	public void SetCloseCb(Action closeCb) {} // 0x00943D90-0x00943DA0
	public void SetDecideCb(Action<uint> decideCb) {} // 0x00943DA0-0x00943DB0
	private void DataReset() {} // 0x00943DB0-0x00943E50
	private void DataReset_Decide(uint u) {} // 0x00943E50-0x00943F20
}

