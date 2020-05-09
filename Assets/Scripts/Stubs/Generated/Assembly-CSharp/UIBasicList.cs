/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A420-0x0060A430
public class UIBasicList : UIListBase // TypeDefIndex: 6458
{
	// Fields
	public int itemViewCount; // 0x2C
	public int interval; // 0x30
	public GameObject UICursorSrc; // 0x38
	public bool cursorFront; // 0x40
	protected GameObject UICursorInst_; // 0x48
	private Vector3 cursorBasePosition_; // 0x50
	protected bool bCursorVisible_; // 0x5C
	private GameObject UIScrollBarInst_; // 0x60
	private Vector3 scrollBarBasePosition_; // 0x68
	private bool bFittingInitialized_; // 0x74
	private Vector2 mySize_; // 0x78
	private Vector2 parentSize_; // 0x80

	// Properties
	public bool CursorVisible { get => default; set {} } // 0x007EA070-0x007EA080 0x007EA060-0x007EA070
	public int ViewCount { get => default; set {} } // 0x007EA080-0x007EA090 0x007EA090-0x007EA0A0

	// Constructors
	public UIBasicList() {} // 0x007EAF00-0x007EAF10

	// Methods
	protected override int _getColumnCount() => default; // 0x007EA050-0x007EA060
	protected void CreateCursor() {} // 0x007EA0A0-0x007EA220
	protected override void DoEnable() {} // 0x007EA220-0x007EA250
	protected override void DoDisable() {} // 0x007EA3B0-0x007EA480
	protected override void DoAddMenu(GameObject container) {} // 0x007EA480-0x007EA510
	public void SetCursorPosition(int nSelect) {} // 0x007EA510-0x007EA6A0
	public void SetScrollBar(GameObject sb, int itemCount) {} // 0x007EA6A0-0x007EA860
	public void VisibleScrollBar(bool bVisible) {} // 0x007EA860-0x007EA920
	public void SetScrollBarPosition(int itemIndex, int itemCount, int viewCount) {} // 0x007EA920-0x007EABF0
	private void Update() {} // 0x007EABF0-0x007EACD0
	private void _doFittingInitialize() {} // 0x007EA250-0x007EA3B0
	public void FittingSize(float width) {} // 0x007EACD0-0x007EAEA0
	public virtual void DrawList(int nList) {} // 0x007EAEA0-0x007EAF00
}

