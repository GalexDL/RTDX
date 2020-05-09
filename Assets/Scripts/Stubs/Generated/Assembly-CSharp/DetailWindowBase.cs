/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A330-0x0060A340
public abstract class DetailWindowBase : UIWindowBase // TypeDefIndex: 6212
{
	// Fields
	private UIControlTMP textCaption_; // 0x30
	private UIControlTMP textDetail_; // 0x38
	private UIScrollView scScrollView_; // 0x40
	private GameObject guide_; // 0x48

	// Properties
	public UIControlTMP TextDetail_ { get; } // 0x009938E0-0x009938F0 
	public UIScrollView ScrollView { get; } // 0x009938F0-0x00993900 

	// Constructors
	protected DetailWindowBase() {} // 0x009938D0-0x009938E0

	// Methods
	public override void Init(GameObject detail) {} // 0x00993900-0x00993BC0
	public void updateCaption() {} // 0x00993BC0-0x00993C70
	public void setTextDetail(string sText) {} // 0x00993C70-0x00993E00
	public void setTextDetail(int textId) {} // 0x00993E00-0x00993F00
	public virtual void SetKeyGuide(bool force = false /* Metadata: 0x00612AA6 */) {} // 0x00993F00-0x00993F80
	public void CloseKeyGuide() {} // 0x00993F80-0x00993F90
	public void updateScrollView() {} // 0x00993F90-0x009940B0
	protected virtual bool _doLinkStart() => default; // 0x009940B0-0x00994200
	public bool IsScroll() => default; // 0x00994200-0x00994230
	public void ChangeScrollBarButtonGuide() {} // 0x00994230-0x009942D0
}

