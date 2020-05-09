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

[ExecuteInEditMode] // 0x0060A5F0-0x0060A600
public class UIGeneralMenu : UIManagerBase // TypeDefIndex: 6921
{
	// Fields
	protected Action onButtonXcallback; // 0x20
	protected ListWindow listWindow_; // 0x28
	protected BasicListWindow.InitParam listParam_; // 0x30

	// Nested types
	public class Item // TypeDefIndex: 6922
	{
		// Fields
		public int id; // 0x10
		[Obsolete] // 0x00618710-0x00618750
		public string sTextId; // 0x18
		public TextId textId; // 0x20
		public bool bEnable; // 0x28

		// Constructors
		public Item() {} // 0x00A77750-0x00A77760
	}

	protected class ListWindow : BasicListWindow // TypeDefIndex: 6923
	{
		// Properties
		public UIBasicList List { get => default; } // 0x00A7BC50-0x00A7BC60 

		// Constructors
		public ListWindow() {} // 0x00A7B150-0x00A7B160

		// Methods
		protected override void _updatePageNumber() {} // 0x00A7C3D0-0x00A7C5E0
	}

	// Constructors
	public UIGeneralMenu() {} // 0x00A7BC60-0x00A7BC70

	// Methods
	public static UIGeneralMenu Create(string sCustomMenu = null) => default; // 0x00A7AEC0-0x00A7B0B0
	public void Construct() {} // 0x00A7B0B0-0x00A7B150
	// [IteratorStateMachine] // 0x00628C70-0x00628CE0
	public virtual IEnumerator MainFlow(Action<int> resultCb) => default; // 0x00A7B160-0x00A7B1E0
	// [IteratorStateMachine] // 0x00628CE0-0x00628D50
	public virtual IEnumerator MainFlow(Item[] itemTable, int defaultIndex, Action<int> resultCb) => default; // 0x00A7B210-0x00A7B2A0
	// [IteratorStateMachine] // 0x00628D50-0x00628DC0
	public virtual IEnumerator MainFlow(Item[] itemTable, int defaultIndex = 0 /* Metadata: 0x006131C6 */) => default; // 0x00A7B2D0-0x00A7B350
	public void Continue() {} // 0x00A7B380-0x00A7B390
	private void Start() {} // 0x00A7B390-0x00A7B3A0
	private void Update() {} // 0x00A7B3A0-0x00A7B480
	public void SetListViewType(UISelectorManager.ViewType type) {} // 0x00A7B480-0x00A7B490
	public void SetCaption(string caption) {} // 0x00A7B490-0x00A7B5F0
	public void SetCaption(TextId caption) {} // 0x00A7B5F0-0x00A7B620
	public void SetFitting(bool bEnable, int nLimit = 0 /* Metadata: 0x006131CA */) {} // 0x00A7B620-0x00A7B640
	public void EnableCancel(bool bEnable) {} // 0x00A77740-0x00A77750
	public void EnableSeDecide(bool bEnable) {} // 0x00A7B640-0x00A7B650
	public void SetApplyRectTransform(string sToken) {} // 0x00A7B650-0x00A7B790
	public void SetPosition(Vector2 v) {} // 0x00A7B790-0x00A7B890
	public void SetVisible(bool bEnable) {} // 0x00A7B890-0x00A7B960
	public void SetButtonXCallBack(Action cb) {} // 0x00A7B960-0x00A7B970
	protected void _initialize(Item[] itemTable, int defaultIndex) {} // 0x00A7B970-0x00A7BC40
}

