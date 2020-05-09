/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace menuitem
{
	public class MenuGenericItemModel<T> : MenuItemModel // TypeDefIndex: 8451
	{
		// Fields
		private int nowIndex; // 0x00
		private bool isLoop; // 0x00
		private T[] itemArray; // 0x00
		private int id; // 0x00
		private LabelFormat funcFormat; // 0x00
		private Action<int, int, T> onSelect; // 0x00
		private Action<int, int, T> onDelaySelect; // 0x00
	
		// Properties
		public override int Index { get => default; }
		public override string Label { get => default; }
		public override bool IsPrev { get => default; }
		public override bool IsNext { get => default; }
		public override GameObject SubDialog { get => default; }
	
		// Nested types
		public delegate string LabelFormat(int index, T item); // TypeDefIndex: 8452; 0x00000000-0x00000000
	
		public delegate bool FindItem(T item); // TypeDefIndex: 8453; 0x00000000-0x00000000
	
		// Constructors
		public MenuGenericItemModel() {}
	
		// Methods
		public void SetItems(bool isLoop, int id, ICollection<T> items, LabelFormat funcFormat, Action<int, int, T> onSelect, Action<int, int, T> onDelaySelect = null) {}
		public override int MoveToIndex(int index) => default;
		public override int MoveIndex(int offset) => default;
		public override void OnSelectItem(int index) {}
		public override void OnDelaySelectItem(int index) {}
		public void SetDefault(FindItem findFunction) {}
	}
}
