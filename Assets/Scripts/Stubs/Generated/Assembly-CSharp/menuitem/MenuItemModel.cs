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
	public abstract class MenuItemModel // TypeDefIndex: 8457
	{
		// Properties
		public abstract int Index { get; }
		public abstract string Label { get; }
		public abstract bool IsNext { get; }
		public abstract bool IsPrev { get; }
		public abstract GameObject SubDialog { get; }
	
		// Constructors
		protected MenuItemModel() {} // 0x00A0DCE0-0x00A0DCF0
	
		// Methods
		public abstract int MoveIndex(int offset);
		public abstract int MoveToIndex(int index);
		public abstract void OnSelectItem(int index);
		public virtual void OnDelaySelectItem(int index) {} // 0x00A0E660-0x00A0E670
		public void OnSelectByOtherUI(int index, Action reportCallback) {} // 0x00A0E670-0x00A0E6B0
	}
}
