/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class MenuPageItemModel : MenuItemModel // TypeDefIndex: 8474
	{
		// Fields
		private int maxNum; // 0x18
		private int nowNum; // 0x1C
	
		// Properties
		public override bool IsShowPrev { get => default; } // 0x0074F320-0x0074F330 
		public override bool IsShowNext { get => default; } // 0x0074F330-0x0074F340 
		public override bool isExistNext { get => default; } // 0x0074F340-0x0074F360 
		public override bool isExistPrev { get => default; } // 0x0074F360-0x0074F370 
	
		// Constructors
		public MenuPageItemModel() {} // Dummy constructor
		public MenuPageItemModel(int defaultMax) {} // 0x0074F370-0x0074F3A0
	
		// Methods
		public override bool SelectIndex(int index) => default; // 0x0074F3A0-0x0074F3D0
		public override string GetCurrent() => default; // 0x0074F3D0-0x0074F470
		public override string GetNext() => default; // 0x0074F470-0x0074F4C0
		public override string GetPrev() => default; // 0x0074F4C0-0x0074F510
		public override string GetSkipNext(int num) => default; // 0x0074F510-0x0074F570
		public override string GetSkipPrev(int num) => default; // 0x0074F570-0x0074F5C0
		protected override int GetSelectedIndex() => default; // 0x0074F5C0-0x0074F5D0
		public override void OnSelectItem() {} // 0x0074F5D0-0x0074F5E0
		public override void OnDelayItemSelect() {} // 0x0074F5E0-0x0074F5F0
		public override void Initialize() {} // 0x0074F5F0-0x0074F600
		public void SetMax(int max) {} // 0x0074F600-0x0074F610
	}
}
