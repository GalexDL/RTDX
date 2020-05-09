/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public abstract class MenuItemModel // TypeDefIndex: 8473
	{
		// Fields
		private MenuItemController controller; // 0x10
	
		// Properties
		public virtual bool IsShowPrev { get; } // 0x0074F1E0-0x0074F1F0 
		public virtual bool IsShowNext { get; } // 0x0074F1F0-0x0074F200 
		public abstract bool isExistNext { get; }
		public abstract bool isExistPrev { get; }
		public virtual bool isShowSkip10 { get; } // 0x0074F200-0x0074F210 
		public virtual bool isShowSkip100 { get; } // 0x0074F210-0x0074F220 
		public int SelectedIndex { get; } // 0x0074E590-0x0074E5A0 
	
		// Constructors
		protected MenuItemModel() {} // 0x0074CF80-0x0074CF90
	
		// Methods
		public abstract string GetCurrent();
		public abstract string GetNext();
		public abstract string GetPrev();
		public abstract string GetSkipNext(int num);
		public abstract string GetSkipPrev(int num);
		public abstract void Initialize();
		public abstract void OnSelectItem();
		public abstract void OnDelayItemSelect();
		protected abstract int GetSelectedIndex();
		public abstract bool SelectIndex(int index);
		public void AttachController(MenuItemController controller) {} // 0x0074E580-0x0074E590
		protected void Reset(bool isReport = true /* Metadata: 0x00614B75 */) {} // 0x0074F220-0x0074F320
	}
}
