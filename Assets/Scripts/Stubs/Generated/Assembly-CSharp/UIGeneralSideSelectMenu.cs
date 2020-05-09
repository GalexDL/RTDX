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

[ExecuteInEditMode] // 0x0060A600-0x0060A610
public class UIGeneralSideSelectMenu : UIGeneralMenu // TypeDefIndex: 6930
{
	// Fields
	protected int cursorIndex_; // 0x38

	// Nested types
	public struct Item // TypeDefIndex: 6931
	{
		// Fields
		public int id; // 0x10
		[Obsolete] // 0x00618750-0x00618790
		public string sTextId; // 0x18
		public TextId textId; // 0x20
		public SideMenuBase sideMenu; // 0x28
	}

	public abstract class SideMenuBase // TypeDefIndex: 6932
	{
		// Constructors
		protected SideMenuBase() {} // 0x00A7DD20-0x00A7DD30

		// Methods
		public abstract bool OnLeft();
		public abstract bool OnRight();
		public abstract string GetDrawText();
		public abstract float GetMaxPrefferdWidth(UIControlTMP text);
		public abstract int GetResult();
		public abstract int GetResultCode();
	}

	public class SideMenuItem : SideMenuBase // TypeDefIndex: 6933
	{
		// Fields
		protected int curIdx_; // 0x10
		protected Item[] itemTable_; // 0x18

		// Properties
		public int CurrentIndex { get => default; set {} } // 0x00A7E280-0x00A7E290 0x00A7E260-0x00A7E280
		public int CurrentID { get => default; set {} } // 0x00A7E330-0x00A7E390 0x00A7E290-0x00A7E330

		// Nested types
		protected struct Item // TypeDefIndex: 6934
		{
			// Fields
			public int id; // 0x10
			public string sText; // 0x18
		}

		// Constructors
		public SideMenuItem() {} // Dummy constructor
		public SideMenuItem(UIGeneralMenu.Item[] setTable, int defIndex) {} // 0x00A7E530-0x00A7E570

		// Methods
		public void SetTable(UIGeneralMenu.Item[] setTable, int defIndex) {} // 0x00A7E390-0x00A7E530
		public override bool OnLeft() => default; // 0x00A7E570-0x00A7E5B0
		public override bool OnRight() => default; // 0x00A7E5B0-0x00A7E5F0
		public override string GetDrawText() => default; // 0x00A7E5F0-0x00A7E650
		public override float GetMaxPrefferdWidth(UIControlTMP text) => default; // 0x00A7E650-0x00A7E730
		public override int GetResult() => default; // 0x00A7E730-0x00A7E790
		public override int GetResultCode() => default; // 0x00A7E790-0x00A7E880
	}

	public class SideMenuDigit : SideMenuBase // TypeDefIndex: 6935
	{
		// Fields
		protected int min_; // 0x10
		protected int max_; // 0x14
		protected int cur_; // 0x18
		protected int resultCode_; // 0x1C
		protected int offset_; // 0x20
		protected int skipRButton_; // 0x24
		protected int skipLButton_; // 0x28
		protected bool edgeLock; // 0x2C

		// Properties
		public int Min { get => default; set {} } // 0x00A7DD40-0x00A7DD50 0x00A7DD30-0x00A7DD40
		public int Max { get => default; set {} } // 0x00A7DD60-0x00A7DD70 0x00A7DD50-0x00A7DD60
		public int Offset { get => default; } // 0x00A7DD70-0x00A7DD80 
		public int Offset_Value { get => default; set {} } // 0x00A7DD90-0x00A7DDA0 0x00A7DD80-0x00A7DD90
		public int SkipRButton { get => default; set {} } // 0x00A7DDB0-0x00A7DDC0 0x00A7DDA0-0x00A7DDB0
		public int SkipLButton { get => default; set {} } // 0x00A7DDD0-0x00A7DDE0 0x00A7DDC0-0x00A7DDD0
		public int CurrentValue { get => default; set {} } // 0x00A7DDF0-0x00A7DE00 0x00A7DDE0-0x00A7DDF0

		// Constructors
		public SideMenuDigit() {} // Dummy constructor
		public SideMenuDigit(int min, int max, int def, int code) {} // 0x00A7DE00-0x00A7DE60
		public SideMenuDigit(int min, int max, int def, int code, int offset) {} // 0x00A7DE60-0x00A7DEC0

		// Methods
		public override bool OnLeft() => default; // 0x00A7DEC0-0x00A7E000
		public override bool OnRight() => default; // 0x00A7E000-0x00A7E130
		public override string GetDrawText() => default; // 0x00A7E130-0x00A7E170
		public override float GetMaxPrefferdWidth(UIControlTMP text) => default; // 0x00A7E170-0x00A7E240
		public override int GetResult() => default; // 0x00A7E240-0x00A7E250
		public override int GetResultCode() => default; // 0x00A7E250-0x00A7E260
	}

	protected class SideSelectWindow : UIGeneralMenu.ListWindow // TypeDefIndex: 6936
	{
		// Constructors
		public SideSelectWindow() {} // 0x00A7C860-0x00A7C870

		// Methods
		protected override bool _doLeft() => default; // 0x00A7E880-0x00A7EA40
		protected override bool _doRight() => default; // 0x00A7EA50-0x00A7EC10
		// [IteratorStateMachine] // 0x0064C380-0x0064C3F0
		public new IEnumerator MainFlow(Action<int> resultCb) => default; // 0x00A7D490-0x00A7D510
		// [IteratorStateMachine] // 0x0064C3F0-0x0064C460
		public IEnumerator MainFlow(Action<int, int> resultCb) => default; // 0x00A7DA90-0x00A7DB10
		public int GetLastCursorIndex() => default; // 0x00A7EC70-0x00A7EC80
	}

	protected class SideSelectItem : UIBasicSelectItem // TypeDefIndex: 6941
	{
		// Fields
		public SideMenuBase sideMenu; // 0x28

		// Constructors
		public SideSelectItem() {} // 0x00A7D2A0-0x00A7D2B0
	}

	protected class SideSelector : UIBasicSelector // TypeDefIndex: 6942
	{
		// Fields
		private static string[] textTokens; // 0x00

		// Constructors
		public SideSelector() {} // 0x00A7D090-0x00A7D100
		static SideSelector() {} // 0x00A800D0-0x00A802D0

		// Methods
		protected string GetDrawText() => default; // 0x00A7F360-0x00A7F460
		public UISelectItem GetSelectItem() => default; // 0x00A7EA40-0x00A7EA50
		protected override void SetupFace() {} // 0x00A7F460-0x00A7FD70
		public override float GetPrefferdWidth() => default; // 0x00A7FD70-0x00A800D0
	}

	// Constructors
	public UIGeneralSideSelectMenu() {} // 0x00A7CF40-0x00A7CF50

	// Methods
	public static UIGeneralSideSelectMenu Create(string sCustomMenu = null) => default; // 0x00A7C5E0-0x00A7C7D0
	public new void Construct() {} // 0x00A7C7D0-0x00A7C860
	// [IteratorStateMachine] // 0x00628DC0-0x00628E30
	public override IEnumerator MainFlow(Action<int> resultCb) => default; // 0x00A7C870-0x00A7C8F0
	// [IteratorStateMachine] // 0x00628E30-0x00628EA0
	public virtual IEnumerator MainFlow(Item[] itemTable, int defaultIndex, Action<int> resultCb) => default; // 0x00A7C920-0x00A7C9B0
	// [IteratorStateMachine] // 0x00628EA0-0x00628F10
	public virtual IEnumerator MainFlow(Item[] itemTable, int defaultIndex = 0 /* Metadata: 0x006131CE */) => default; // 0x00A7C9E0-0x00A7CA60
	// [IteratorStateMachine] // 0x00628F10-0x00628F80
	public virtual IEnumerator MainFlow(Action<int, int> resultCb) => default; // 0x00A7CA90-0x00A7CB10
	// [IteratorStateMachine] // 0x00628F80-0x00628FF0
	public virtual IEnumerator MainFlow(Item[] itemTable, int defaultIndex, Action<int, int> resultCb) => default; // 0x00A7CB40-0x00A7CBD0
	public void ForceUpdateFace() {} // 0x00A7CC00-0x00A7CC50
	protected void _initialize(Item[] itemTable, int defaultIndex) {} // 0x00A7CC50-0x00A7CF30
}

