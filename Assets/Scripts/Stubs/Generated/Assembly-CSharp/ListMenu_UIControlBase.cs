/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public abstract class ListMenu_UIControlBase : UIBehaviour // TypeDefIndex: 8065
{
	// Fields
	protected ListMenu_Logic logic_; // 0x18

	// Properties
	public ListMenu_Logic Logic { get; } // 0x00904D50-0x00904D60 
	public abstract string Caption { get; set; }

	// Events
	public event CallbackAction actionCalled;

	// Nested types
	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 8066; 0x00904FC0-0x00905370

	public enum EventType // TypeDefIndex: 8067
	{
		Open = 0,
		Close = 1,
		Focus = 2,
		Unfocus = 3,
		ItemSort = 4,
		ItemAdd = 5,
		ItemRemove = 6,
		ItemSelect = 7,
		ItemUnselect = 8
	}

	public enum ActionType // TypeDefIndex: 8068
	{
		Decide = 0,
		Cancel = 1,
		ItemSelect = 2,
		ItemUnselect = 3,
		Focus = 4,
		Unfocus = 5
	}

	// Constructors
	protected ListMenu_UIControlBase() {} // 0x00905370-0x00905390

	// Methods
	public void Set(ListMenu_Logic logic) {} // 0x00904D40-0x00904D50
	public virtual void Event(EventType evt, ListMenu_Logic.Item item) {} // 0x00904F80-0x00904F90
	public virtual void Action(ActionType action, ListMenu_Logic.Item item) {} // 0x00904F90-0x00904FC0
}

