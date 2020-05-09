/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ItemEquippedListWindow : BasicListWindow // TypeDefIndex: 6234
{
	// Nested types
	protected class UILocalSelector : UISelectorBase // TypeDefIndex: 6235
	{
		// Fields
		private PokemonWarehouseId wId_; // 0x30
		private UIFaceWindow faceWindow_; // 0x40

		// Properties
		public PokemonWarehouseId WareHouseID { get => default; set {} } // 0x008FD7A0-0x008FD7B0 0x008FD790-0x008FD7A0
		public int PresetIndex { get; set; } // 0x008FD7B0-0x008FD7C0 0x008FD780-0x008FD790

		// Constructors
		public UILocalSelector() {} // 0x008FD710-0x008FD780

		// Methods
		protected override void SetupFace() {} // 0x008FD7C0-0x008FDE50
	}

	// Constructors
	public ItemEquippedListWindow() {} // 0x008FD4B0-0x008FD4C0

	// Methods
	public void Init(GameObject objRoot, int initItemIndex, int presetIndex) {} // 0x008FD0E0-0x008FD2B0
	private bool remove(UISelectorBase sel) => default; // 0x008FD2C0-0x008FD420
	protected override bool _onYButton() => default; // 0x008FD420-0x008FD4A0
}

