/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A630-0x0060A640
public class UILeaderChangeMenu : UIManagerBase // TypeDefIndex: 7038
{
	// Fields
	protected CommonScreen commonScreen_; // 0x20
	private List<int> memberIds; // 0x28
	private List<bool> memberAvailables; // 0x30
	private int selectMemeberId; // 0x38
	private int focusIndex_; // 0x3C
	private GameObject[] displayStatusObj; // 0x40
	private string sOrganizationNoToken; // 0x48
	private ButtonSelectWindow buttonSelect_; // 0x50

	// Constructors
	public UILeaderChangeMenu() {} // 0x00941E30-0x00941EE0

	// Methods
	public void Init() {} // 0x00941250-0x009412D0
	public static UILeaderChangeMenu Create(string sCustomMenu = null) => default; // 0x009412D0-0x009414A0
	public void Construct() {} // 0x009414A0-0x00941540
	private void _cbFromChangeMenu(ListWindowBase.ActionType act) {} // 0x00941540-0x009418B0
	// [IteratorStateMachine] // 0x00629C20-0x00629C90
	public virtual IEnumerator MainFlow(Action<int> resultCb) => default; // 0x009418D0-0x00941950
	public void Continue() {} // 0x009418C0-0x009418D0
	private void Start() {} // 0x00941980-0x00941990
	private void Update() {} // 0x00941990-0x009419E0
	public void SetListViewType(UISelectorManager.ViewType type) {} // 0x009419E0-0x009419F0
	public void SetCaption(string caption) {} // 0x009419F0-0x00941B50
	public void SetCaption(TextId caption) {} // 0x00941B50-0x00941B80
	public void SetVisible(bool bEnable) {} // 0x00941B80-0x00941C50
	private void HideNoIcon() {} // 0x00941C50-0x00941E30
}

