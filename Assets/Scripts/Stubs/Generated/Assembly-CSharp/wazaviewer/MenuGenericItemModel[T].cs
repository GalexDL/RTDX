/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace wazaviewer
{
	public class MenuGenericItemModel<T> : MenuItemModel // TypeDefIndex: 8442
	{
		// Fields
		private ICollection<T> listItems; // 0x00
		private T[] itemArray; // 0x00
		private int nowIndex; // 0x00
		private bool isLoop; // 0x00
		private ItemFormat funcFormat; // 0x00
		private FilterMatching funcFilter; // 0x00
		private Action<int, T> funcOnSelect; // 0x00
	
		// Properties
		public override string CurrentItemLabel { get => default; }
		public override int ItemNumber { get => default; }
		public override int CurrentIndex { get => default; }
		public override bool IsExistNext { get => default; }
		public override bool IsExistPrev { get => default; }
		public override bool IsIndexDialog { get => default; }
	
		// Nested types
		public delegate string ItemFormat(int index, T item); // TypeDefIndex: 8443; 0x00000000-0x00000000
	
		public delegate bool FilterMatching(string[] hitInitial, int index, T item); // TypeDefIndex: 8444; 0x00000000-0x00000000
	
		// Constructors
		public MenuGenericItemModel() {} // Dummy constructor
		public MenuGenericItemModel(bool isLoop, ItemFormat funcFormat, FilterMatching funcFilter, Action<int, T> onSelect) {}
	
		// Methods
		public void SetItems(ICollection<T> items, int defaultIndex = 0 /* Metadata: 0x00614B3E */) {}
		public override int MoveIndex(int moveValue) => default;
		public override int MoveToIndex(int index) => default;
		public override string GetItemLabel(int index) => default;
		public override int[] GetItemsOnFilter(int beginIndex, string[] hitInitial, int maxItems, bool bNotHit) => default;
		public override bool SelectItem(int index) => default;
		public T GetItem(int index) => default;
	}
}
