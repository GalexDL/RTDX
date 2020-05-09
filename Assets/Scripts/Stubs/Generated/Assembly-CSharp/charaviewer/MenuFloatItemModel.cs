/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class MenuFloatItemModel : MenuItemModel // TypeDefIndex: 8468
	{
		// Fields
		private float initValue; // 0x18
		private float nowValue; // 0x1C
		private float stepValue; // 0x20
		private float min; // 0x24
		private float max; // 0x28
		private string format; // 0x30
		private Action<float> callback; // 0x38
		private Action<float> delayCallback; // 0x40
	
		// Properties
		public override bool isExistNext { get => default; } // 0x0074CE60-0x0074CE80 
		public override bool isExistPrev { get => default; } // 0x0074CE80-0x0074CEA0 
	
		// Constructors
		public MenuFloatItemModel() {} // Dummy constructor
		public MenuFloatItemModel(string format, float initialValue, float step, float min, float max, Action<float> callback, Action<float> delayCallback = null) {} // 0x0074CEA0-0x0074CF80
	
		// Methods
		protected override int GetSelectedIndex() => default; // 0x0074CF90-0x0074CFA0
		public override bool SelectIndex(int index) => default; // 0x0074CFA0-0x0074CFB0
		public override string GetCurrent() => default; // 0x0074CFB0-0x0074CFD0
		public override string GetNext() => default; // 0x0074CFD0-0x0074CFE0
		public override string GetPrev() => default; // 0x0074CFE0-0x0074D000
		public override string GetSkipNext(int num) => default; // 0x0074D000-0x0074D030
		public override string GetSkipPrev(int num) => default; // 0x0074D030-0x0074D060
		public override void Initialize() {} // 0x0074D060-0x0074D080
		public override void OnSelectItem() {} // 0x0074D080-0x0074D0E0
		public override void OnDelayItemSelect() {} // 0x0074D0E0-0x0074D150
	}
}
