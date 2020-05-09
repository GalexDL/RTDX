/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class MenuFocusTarget : MonoBehaviour // TypeDefIndex: 8469
	{
		// Fields
		[SerializeField] // 0x00617490-0x006174A0
		private MenuItemController menuItem; // 0x18
		private bool isFocus; // 0x20
	
		// Properties
		public bool IsMenuItem { get => default; } // 0x0074D150-0x0074D1C0 
		public bool IsFocus { get => default; set {} } // 0x0074D1C0-0x0074D1D0 0x0074D1D0-0x0074D2E0
	
		// Constructors
		public MenuFocusTarget() {} // 0x0074E020-0x0074E030
	
		// Methods
		public void SetSelector(MenuItemController.IMenuItemSelector selector, int index) {} // 0x0074D450-0x0074D4F0
		public int GetSelectorIndex() => default; // 0x0074D500-0x0074D5A0
		public void NextValue() {} // 0x0074D5C0-0x0074D6B0
		public void PrevValue() {} // 0x0074D740-0x0074D830
		public void NextSkip10() {} // 0x0074D8C0-0x0074D9C0
		public void NextSkip100() {} // 0x0074DA90-0x0074DB90
		public void PrevSkip10() {} // 0x0074DB90-0x0074DC90
		public void PrevSkip100() {} // 0x0074DD70-0x0074DE70
		public void Click() {} // 0x0074DE70-0x0074E020
	}
}
