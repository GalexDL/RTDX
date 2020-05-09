/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace wazaviewer
{
	public abstract class MenuItemModel // TypeDefIndex: 8445
	{
		// Properties
		public abstract string CurrentItemLabel { get; }
		public abstract int ItemNumber { get; }
		public abstract int CurrentIndex { get; }
		public abstract bool IsExistNext { get; }
		public abstract bool IsExistPrev { get; }
		public virtual bool IsIndexDialog { get; } // 0x00B02260-0x00B02270 
	
		// Constructors
		protected MenuItemModel() {} // 0x00B01EB0-0x00B01EC0
	
		// Methods
		public abstract int MoveIndex(int moveValue);
		public abstract int MoveToIndex(int index);
		public abstract string GetItemLabel(int index);
		public abstract int[] GetItemsOnFilter(int beginIndex, string[] hitInitial, int maxItems, bool bNotHit);
		public abstract bool SelectItem(int index);
	}
}
