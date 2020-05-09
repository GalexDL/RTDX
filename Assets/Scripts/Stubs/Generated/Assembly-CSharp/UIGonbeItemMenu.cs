/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIGonbeItemMenu : UIBasicItemBagMenu // TypeDefIndex: 6951
{
	// Fields
	protected UIAskMenu actionMenu_; // 0x60
	protected CommonScreen commonScreen_; // 0x68
	private ItemBag itemBag; // 0x70
	private bool bNowFootPage_; // 0x78

	// Constructors
	public UIGonbeItemMenu() {} // 0x00A80CB0-0x00A80CC0

	// Methods
	private new void Start() {} // 0x00A802D0-0x00A802E0
	private new void Update() {} // 0x00A802E0-0x00A80350
	public static UIGonbeItemMenu Create() => default; // 0x00A80350-0x00A80470
	public override void Construct() {} // 0x00A80470-0x00A80560
	protected override void _cbFromListWindow(ListWindowBase.ActionType act) {} // 0x00A80560-0x00A80870
	private bool CheckSelectItemEdible(IItem item) => default; // 0x00A80870-0x00A80950
	public void Init() {} // 0x00A80950-0x00A80B80
	// [IteratorStateMachine] // 0x00628FF0-0x00629060
	public override IEnumerator MainFlow(Action<Result> cb = null) => default; // 0x00A80B80-0x00A80C00
	private void _updateCaption(bool bForce) {} // 0x00A80C30-0x00A80CB0
}

