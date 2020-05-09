/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace menuitem
{
	public class MenuBoolItemModel : MenuItemModel // TypeDefIndex: 8450
	{
		// Fields
		private bool nowValue; // 0x10
		private TextIDHash[] labelArray; // 0x18
		private Action<bool> onSelect; // 0x20
	
		// Properties
		public override int Index { get => default; } // 0x00A0DAD0-0x00A0DAE0 
		public override string Label { get => default; } // 0x00A0DAE0-0x00A0DBB0 
		public override bool IsNext { get => default; } // 0x00A0DBB0-0x00A0DBC0 
		public override bool IsPrev { get => default; } // 0x00A0DBC0-0x00A0DBD0 
		public override GameObject SubDialog { get => default; } // 0x00A0DBD0-0x00A0DBE0 
	
		// Constructors
		public MenuBoolItemModel() {} // 0x00A0DCD0-0x00A0DCE0
	
		// Methods
		public void SetItems(bool defaultValue, TextIDHash[] labels, Action<bool> onSelect) {} // 0x00A0DBE0-0x00A0DBF0
		public override int MoveToIndex(int index) => default; // 0x00A0DBF0-0x00A0DC10
		public override int MoveIndex(int offset) => default; // 0x00A0DC10-0x00A0DC50
		public override void OnSelectItem(int index) {} // 0x00A0DC50-0x00A0DCD0
	}
}
