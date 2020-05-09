/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class MenuToggleItemModel : MenuItemModel // TypeDefIndex: 8478
	{
		// Fields
		private bool isLoop; // 0x18
		private bool defaultValue; // 0x19
		private bool isToggleOn; // 0x1A
		private string[] textLabel; // 0x20
		private Action<bool> callback; // 0x28
		private Action<bool> delayCallback; // 0x30
	
		// Properties
		public override bool isExistNext { get => default; } // 0x0074FA90-0x0074FAB0 
		public override bool isExistPrev { get => default; } // 0x0074FAB0-0x0074FAD0 
	
		// Constructors
		public MenuToggleItemModel() {} // Dummy constructor
		public MenuToggleItemModel(bool defaultValue, string[] textLabel, Action<bool> callback, Action<bool> delayCallback = null, bool isLoop = true /* Metadata: 0x00614B7C */) {} // 0x0074FAD0-0x0074FB40
	
		// Methods
		public override void Initialize() {} // 0x0074FB40-0x0074FB50
		public override string GetCurrent() => default; // 0x0074FB50-0x0074FBB0
		public override string GetNext() => default; // 0x0074FBB0-0x0074FC00
		public override string GetPrev() => default; // 0x0074FC00-0x0074FC50
		public override string GetSkipNext(int num) => default; // 0x0074FC50-0x0074FCA0
		public override string GetSkipPrev(int num) => default; // 0x0074FCA0-0x0074FCF0
		public override void OnSelectItem() {} // 0x0074FCF0-0x0074FD50
		public override void OnDelayItemSelect() {} // 0x0074FD50-0x0074FDC0
		protected override int GetSelectedIndex() => default; // 0x0074FDC0-0x0074FDD0
		public override bool SelectIndex(int index) => default; // 0x0074FDD0-0x0074FE00
	}
}
