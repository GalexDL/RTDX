/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.waza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class WazaChangeWindowBase : UIManagerBase // TypeDefIndex: 7990
{
	// Fields
	public PokemonStatus pokemonStatus_; // 0x20
	private GameObject mainObj_; // 0x28
	private int nAnimCount_; // 0x30
	private ViewState viewState_; // 0x34
	private FaceWindow faceWindow_; // 0x38
	private renkertsu renketsuWazaSingleListWindow_; // 0x40
	private WazaChange wazaChangeWindow_; // 0x48
	private WazaForgetWindow wazaForgetWindow_; // 0x50
	private WazaRememberWindow wazaRemenberWindow_; // 0x58

	// Nested types
	public enum ViewState // TypeDefIndex: 7991
	{
		NONE = 0,
		OPENED = 1,
		CLOSED = 2
	}

	private class FaceWindow // TypeDefIndex: 7992
	{
		// Constructors
		public FaceWindow() {} // 0x00741D70-0x00741D80

		// Methods
		public void Init(GameObject obj) {} // 0x00741DB0-0x00741DC0
	}

	private class renkertsu : RenketsuWazaSingleListWindow // TypeDefIndex: 7993
	{
		// Constructors
		public renkertsu() {} // 0x007441D0-0x007441E0

		// Methods
		public override void Init(GameObject root) {} // 0x007441C0-0x007441D0
	}

	public class WazaChange : BasicListWindow // TypeDefIndex: 7994
	{
		// Fields
		private List<wazaItem> wazaItemList_; // 0x88
		private GameObject obj_; // 0x90

		// Nested types
		public class wazaItem // TypeDefIndex: 7995
		{
			// Fields
			public int slotID; // 0x10
			public Index wazaIndex; // 0x14
			public IPokemonStatus pokemonStatus; // 0x18

			// Constructors
			public wazaItem() {} // 0x00742490-0x007424A0
		}

		public class UILocalSelectItem : UISelectItem // TypeDefIndex: 7996
		{
			// Fields
			private wazaItem item_; // 0x18

			// Properties
			public wazaItem Item { get => default; set {} } // 0x007435E0-0x007435F0 0x00743420-0x00743430

			// Constructors
			public UILocalSelectItem() {} // 0x00743410-0x00743420
		}

		private class UILocalSelector : UISelectorBase // TypeDefIndex: 7997
		{
			// Constructors
			public UILocalSelector() {} // 0x00743570-0x007435E0

			// Methods
			protected override void SetupFace() {} // 0x007435F0-0x007441A0
		}

		// Constructors
		public WazaChange() {} // 0x00741D80-0x00741D90

		// Methods
		public virtual void Init(GameObject obj, IPokemonStatus pokemonStatus, Index wazaIndex) {} // 0x00742080-0x00742490
		public void SetActive(bool b) {} // 0x007424A0-0x007424B0
		public void UpdateWazaInfo_Twin(GameObject mainObj, IPokemonStatus status, int wazaId) {} // 0x007424B0-0x007424C0
		public void UpdateWazaInfo(GameObject mainObj, IPokemonStatus status, int wazaId) {} // 0x007424C0-0x00742E40
		private void _setStatusGage(GameObject obj, int power, int addPower, bool bPowerMax, bool bFit = true /* Metadata: 0x00613C16 */) {} // 0x00742EB0-0x00743350
	}

	private class WazaForgetWindow // TypeDefIndex: 7999
	{
		// Constructors
		public WazaForgetWindow() {} // 0x00741D90-0x00741DA0

		// Methods
		public void Init(GameObject obj) {} // 0x007441A0-0x007441B0
	}

	private class WazaRememberWindow // TypeDefIndex: 8000
	{
		// Constructors
		public WazaRememberWindow() {} // 0x00741DA0-0x00741DB0

		// Methods
		public void Init(GameObject obj) {} // 0x007441B0-0x007441C0
	}

	// Constructors
	public WazaChangeWindowBase() {} // 0x00741EA0-0x00741EB0

	// Methods
	public void Init(GameObject mainObj, PokemonStatus pokemonStatus) {} // 0x00741A20-0x00741D70
	private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00741DC0-0x00741DF0
	// [IteratorStateMachine] // 0x0062FF50-0x0062FFC0
	public IEnumerator OpenWazaChangeWindow(Action cb) => default; // 0x00741DF0-0x00741E70
}

