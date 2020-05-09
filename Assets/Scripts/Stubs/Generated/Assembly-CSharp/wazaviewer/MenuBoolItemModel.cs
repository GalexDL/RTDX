/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace wazaviewer
{
	public class MenuBoolItemModel : MenuItemModel // TypeDefIndex: 8441
	{
		// Fields
		private bool nowValue; // 0x10
		private Action<bool> funcOnSelect; // 0x18
		private string[] labels; // 0x20
	
		// Properties
		public override string CurrentItemLabel { get => default; } // 0x00B01DE0-0x00B01E30 
		public override int ItemNumber { get => default; } // 0x00B01E30-0x00B01E40 
		public override int CurrentIndex { get => default; } // 0x00B01E40-0x00B01E50 
		public override bool IsExistNext { get => default; } // 0x00B01E50-0x00B01E60 
		public override bool IsExistPrev { get => default; } // 0x00B01E60-0x00B01E70 
	
		// Constructors
		public MenuBoolItemModel() {} // Dummy constructor
		public MenuBoolItemModel(string[] labels, Action<bool> funcOnSelect) {} // 0x00B01E70-0x00B01EB0
	
		// Methods
		public override int MoveIndex(int moveValue) => default; // 0x00B01EC0-0x00B01EE0
		public override int MoveToIndex(int index) => default; // 0x00B01EE0-0x00B01EF0
		public override string GetItemLabel(int index) => default; // 0x00B01EF0-0x00B01F40
		public override int[] GetItemsOnFilter(int beginIndex, string[] hitInitial, int maxItems, bool bNotHit) => default; // 0x00B01F40-0x00B02200
		public override bool SelectItem(int index) => default; // 0x00B02200-0x00B02260
	}
}
