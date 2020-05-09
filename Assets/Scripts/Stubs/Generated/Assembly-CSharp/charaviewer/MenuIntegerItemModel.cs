/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class MenuIntegerItemModel : MenuItemModel // TypeDefIndex: 8470
	{
		// Fields
		private bool isLoop; // 0x18
		private int initValue; // 0x1C
		private int nowValue; // 0x20
		private int min; // 0x24
		private int max; // 0x28
		private string format; // 0x30
		private Action<int> callback; // 0x38
		private Action<int> delayCallback; // 0x40
	
		// Properties
		public override bool isExistNext { get => default; } // 0x0074E030-0x0074E060 
		public override bool isExistPrev { get => default; } // 0x0074E060-0x0074E080 
	
		// Constructors
		public MenuIntegerItemModel() {} // Dummy constructor
		public MenuIntegerItemModel(string format, int defaultValue, int min, int max, Action<int> callback, Action<int> delayCallback = null, bool isLoop = true /* Metadata: 0x00614B6A */) {} // 0x0074E080-0x0074E0F0
	
		// Methods
		protected override int GetSelectedIndex() => default; // 0x0074E0F0-0x0074E100
		public override bool SelectIndex(int index) => default; // 0x0074E100-0x0074E130
		public override string GetCurrent() => default; // 0x0074E130-0x0074E150
		public override string GetNext() => default; // 0x0074E150-0x0074E160
		public override string GetPrev() => default; // 0x0074E160-0x0074E180
		public override string GetSkipNext(int num) => default; // 0x0074E180-0x0074E210
		public override string GetSkipPrev(int num) => default; // 0x0074E210-0x0074E2A0
		public override void Initialize() {} // 0x0074E2A0-0x0074E2C0
		public override void OnSelectItem() {} // 0x0074E2C0-0x0074E320
		public override void OnDelayItemSelect() {} // 0x0074E320-0x0074E390
	}
}
