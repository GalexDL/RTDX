/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class LeavePokemonListWindow : PokemonListWindow // TypeDefIndex: 6299
{
	// Fields
	private GameObject objRoot_; // 0xE8
	private List<IPokemonStatus> originalList_; // 0xF0
	private IPokemonStatus LeavePokemon_; // 0xF8
	private UILeavePokemonListMenu manager_; // 0x100

	// Nested types
	public class UILearvePokemonSelectItem : PokemonListWindowBase.UIPokemonSelectItemBase // TypeDefIndex: 6300
	{
		// Fields
		private IPokemonStatus pokemonStatus_; // 0x28

		// Properties
		public override IPokemonStatus PokemonStatus { get => default; set {} } // 0x00904200-0x00904210 0x009041F0-0x00904200

		// Constructors
		public UILearvePokemonSelectItem() {} // 0x009041E0-0x009041F0
	}

	// Constructors
	public LeavePokemonListWindow() {} // 0x00903DD0-0x00903DE0

	// Methods
	public void Init(GameObject objRoot, List<IPokemonStatus> list, IPokemonStatus LeavePokemon, UILeavePokemonListMenu manager) {} // 0x009033F0-0x00903780
	protected override bool _onYButton() => default; // 0x00903790-0x009037D0
	protected override void ListUpdate() {} // 0x009037D0-0x00903880
	public virtual List<IPokemonStatus> GetDefaultList(List<IPokemonStatus> originalList) => default; // 0x00903990-0x00903AF0
	public virtual List<IPokemonStatus> GetNowList(List<IPokemonStatus> originalList) => default; // 0x00903AF0-0x00903DD0
}

