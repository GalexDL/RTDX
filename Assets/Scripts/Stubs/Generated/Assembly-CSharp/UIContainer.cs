/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A430-0x0060A440
public class UIContainer : MonoBehaviour // TypeDefIndex: 6693
{
	// Fields
	private Dictionary<string, GameObject> tokenMap_; // 0x20

	// Events
	public event CallbackAction actionCalled;

	// Nested types
	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6694; 0x00976A80-0x00976E30

	public enum EventType // TypeDefIndex: 6695
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

	public enum ActionType // TypeDefIndex: 6696
	{
		Decide = 0,
		Cancel = 1,
		ItemSelect = 2,
		ItemUnselect = 3,
		Focus = 4,
		Unfocus = 5
	}

	// Constructors
	public UIContainer() {} // 0x009773A0-0x009773C0

	// Methods
	public virtual void Event(EventType evt) {} // 0x00976A60-0x00976A70
	public virtual void Action(ActionType action) {} // 0x00976A70-0x00976A80
	private void Awake() {} // 0x00976E30-0x00976ED0
	private void SetToken(Transform parent) {} // 0x00976ED0-0x009771B0
	public GameObject FindGameObject(string sToken) => default; // 0x009771B0-0x009773A0
}

