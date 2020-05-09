/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using window;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A6D0-0x0060A750
// [RequireComponent] // 0x0060A6D0-0x0060A750
public class ListMenu_UIControl_WindowSys : ListMenu_UIControlBase // TypeDefIndex: 8063
{
	// Fields
	private Window targetWindow_; // 0x28
	private TextRender textRender_; // 0x30
	private string caption_; // 0x38
	private int cursorItemIdx_; // 0x40
	private const int LIST_INDENT_W = 8; // Metadata: 0x00613CE2

	// Properties
	public override string Caption { get => default; set {} } // 0x00905440-0x00905450 0x00905450-0x00905460

	// Constructors
	public ListMenu_UIControl_WindowSys() {} // 0x009059D0-0x00905A30

	// Methods
	protected override void OnEnable() {} // 0x00905670-0x009056E0
	protected override void OnDisable() {} // 0x009056E0-0x00905720
	protected override void OnRectTransformDimensionsChange() {} // 0x00905720-0x00905750
	private void Update() {} // 0x00905750-0x009059A0
	public override void Event(EventType evt, ListMenu_Logic.Item item) {} // 0x009059A0-0x009059C0
	private void RebuildUI_() {} // 0x00905460-0x00905670
}

