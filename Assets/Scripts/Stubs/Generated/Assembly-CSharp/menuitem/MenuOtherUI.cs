/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace menuitem
{
	public abstract class MenuOtherUI : MonoBehaviour // TypeDefIndex: 8459
	{
		// Fields
		private MenuItemModel parentModel; // 0x18
		private Action reportCallback; // 0x20
	
		// Constructors
		protected MenuOtherUI() {} // 0x00A0E8B0-0x00A0E8C0
	
		// Methods
		public void SetParent(MenuItemModel model, Action reportCallback) {} // 0x00A0E540-0x00A0E550
		public abstract void SetInitialValue(int index);
		protected void SetValue(int index) {} // 0x00A0E800-0x00A0E8B0
	}
}
