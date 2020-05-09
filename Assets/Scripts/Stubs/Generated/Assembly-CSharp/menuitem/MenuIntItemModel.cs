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
	public class MenuIntItemModel : MenuItemModel // TypeDefIndex: 8454
	{
		// Fields
		private int nowIndex; // 0x10
		private int minValue; // 0x14
		private int maxValue; // 0x18
		private bool isLoop; // 0x1C
		private GameObject prefabSubDialog; // 0x20
		private Action<int> onSelect; // 0x28
		private Action<int> onDelaySelect; // 0x30
	
		// Properties
		public override int Index { get => default; } // 0x00A0DCF0-0x00A0DD00 
		public override string Label { get => default; } // 0x00A0DD00-0x00A0DD80 
		public override bool IsNext { get => default; } // 0x00A0DD80-0x00A0DDB0 
		public override bool IsPrev { get => default; } // 0x00A0DDB0-0x00A0DDD0 
		public override GameObject SubDialog { get => default; } // 0x00A0DDD0-0x00A0DDE0 
	
		// Constructors
		public MenuIntItemModel() {} // 0x00A0DFB0-0x00A0DFC0
	
		// Methods
		public void SetItems(bool isLoop, int minValue, int maxValue, Action<int> onSelect, Action<int> onDelaySelect, GameObject prefabOtherUI = null) {} // 0x00A0DDE0-0x00A0DE10
		public void SetRange(int minValue, int maxValue) {} // 0x00A0DE10-0x00A0DE40
		public override int MoveToIndex(int index) => default; // 0x00A0DE40-0x00A0DE90
		public override int MoveIndex(int offset) => default; // 0x00A0DE90-0x00A0DEB0
		public override void OnSelectItem(int index) {} // 0x00A0DEB0-0x00A0DF30
		public override void OnDelaySelectItem(int index) {} // 0x00A0DF30-0x00A0DFB0
	}
}
