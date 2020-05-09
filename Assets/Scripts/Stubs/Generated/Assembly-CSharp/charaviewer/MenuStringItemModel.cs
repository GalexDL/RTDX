/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class MenuStringItemModel : MenuItemModel // TypeDefIndex: 8477
	{
		// Fields
		private bool isLoop; // 0x18
		private string[] itemLabels; // 0x20
		private int nowIndex; // 0x28
		private int initIndex; // 0x2C
		private Action<int, string> callback; // 0x30
		private Action<int, string> delayCallback; // 0x38
	
		// Properties
		public override bool isExistNext { get => default; } // 0x0074F610-0x0074F640 
		public override bool isExistPrev { get => default; } // 0x0074F640-0x0074F660 
		public override bool isShowSkip10 { get => default; } // 0x0074F660-0x0074F680 
		public override bool isShowSkip100 { get => default; } // 0x0074F680-0x0074F6A0 
	
		// Constructors
		public MenuStringItemModel() {} // Dummy constructor
		public MenuStringItemModel(int defaultIndex, string[] itemLabels, Action<int, string> callback, Action<int, string> delayCallback = null, bool isLoop = true /* Metadata: 0x00614B7B */) {} // 0x0074F6A0-0x0074F700
	
		// Methods
		public override string GetCurrent() => default; // 0x0074F700-0x0074F750
		public override string GetNext() => default; // 0x0074F750-0x0074F7B0
		public override string GetPrev() => default; // 0x0074F7B0-0x0074F810
		public override string GetSkipNext(int num) => default; // 0x0074F810-0x0074F890
		public override string GetSkipPrev(int num) => default; // 0x0074F890-0x0074F910
		public override void Initialize() {} // 0x0074F910-0x0074F920
		protected override int GetSelectedIndex() => default; // 0x0074F920-0x0074F930
		public override bool SelectIndex(int index) => default; // 0x0074F930-0x0074F960
		public override void OnSelectItem() {} // 0x0074F960-0x0074F9F0
		public override void OnDelayItemSelect() {} // 0x0074F9F0-0x0074FA90
	}
}
