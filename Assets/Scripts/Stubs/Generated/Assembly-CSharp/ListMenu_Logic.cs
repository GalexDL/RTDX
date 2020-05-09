/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ListMenu_Logic // TypeDefIndex: 8059
{
	// Fields
	private List<Item> menuItems_; // 0x10

	// Properties
	public List<Item> Items { get => default; } // 0x00904710-0x00904720 

	// Nested types
	public class Item // TypeDefIndex: 8060
	{
		// Fields
		public string name; // 0x10
		public bool bGrayed; // 0x18
		public bool bDisable; // 0x19
		public bool bSelect; // 0x1A
		public object param; // 0x20
		public List<KeyValuePair<string, object>> paramTbl; // 0x28

		// Constructors
		public Item() {} // 0x00904C60-0x00904CD0

		// Methods
		public object GetParam(string key) => default; // 0x00904B70-0x00904C50
	}

	// Constructors
	public ListMenu_Logic() {} // 0x00904A70-0x00904AE0

	// Methods
	public Item GetSelectedFirstItem() => default; // 0x00904720-0x00904820
	public void EachListItems(Func<int, Item, bool> func) {} // 0x00904820-0x009048F0
	public void ClearItems() {} // 0x009048F0-0x00904940
	public void InsertItem(int index, Item item) {} // 0x00904940-0x009049D0
	public void RemoveItem(Item item) {} // 0x009049D0-0x00904A30
	public void SortItem() {} // 0x00904A30-0x00904A40
	public void SortItem(Predicate<Item> pred) {} // 0x00904A40-0x00904A50
	public void Select(Item item) {} // 0x00904A50-0x00904A60
	public void Unselect(Item item) {} // 0x00904A60-0x00904A70
}

