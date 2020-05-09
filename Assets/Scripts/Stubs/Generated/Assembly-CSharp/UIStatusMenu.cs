/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIStatusMenu : UIPokemonListMenu // TypeDefIndex: 7576
{
	// Fields
	private CommonScreen commonScreen_; // 0x68
	private GameObject wazaScreenObject_; // 0x70
	private WazaStatusExplainWindow wazaDetailWindow_; // 0x78
	private PokemonStatusCardWindow pokemonCardWindow_; // 0x80
	private RenketsuWazaSingleListWindowLocal wazaListWindow_; // 0x88
	private Mode mode_; // 0x90

	// Nested types
	private class RenketsuWazaSingleListWindowLocal : RenketsuWazaSingleListWindow // TypeDefIndex: 7577
	{
		// Constructors
		public RenketsuWazaSingleListWindowLocal() {} // 0x00E02BF0-0x00E02C00

		// Methods
		protected override bool _decide() => default; // 0x00E043B0-0x00E043C0
	}

	public enum Mode // TypeDefIndex: 7578
	{
		Ground = 0,
		Dungeon = 1
	}

	private class StatusMenu_PokemonWarehouseWindow : PokemonWarehouseListWindow // TypeDefIndex: 7579
	{
		// Fields
		private GameObject objRoot_; // 0xC8
		private UIStatusMenu manager_; // 0xD0

		// Constructors
		public StatusMenu_PokemonWarehouseWindow() {} // 0x00E02FF0-0x00E03000

		// Methods
		public void Init(GameObject objRoot, UIStatusMenu manager) {} // 0x00E03000-0x00E03200
		protected override void ListUpdate() {} // 0x00E043D0-0x00E044A0
		protected override bool _onYButton() => default; // 0x00E044A0-0x00E04550
		public override List<IPokemonWarehouseStatus> SetDefaultList(int presetIndex = -1 /* Metadata: 0x00613859 */) => default; // 0x00E04550-0x00E04840
	}

	// Constructors
	public UIStatusMenu() {} // 0x00E03E70-0x00E03EE0

	// Methods
	public static UIStatusMenu Create() => default; // 0x00E029E0-0x00E02AD0
	public override void Construct() {} // 0x00E02AD0-0x00E02BF0
	public override void Destruct() {} // 0x00E02C00-0x00E02C80
	public void Init(Mode mode = Mode.Ground /* Metadata: 0x0061384C */) {} // 0x00E02C80-0x00E02FF0
	// [IteratorStateMachine] // 0x0062D870-0x0062D8E0
	public override IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00E03200-0x00E03280
	protected override void _cbFromListWindow(ListWindowBase.ActionType act) {} // 0x00E032B0-0x00E032C0
	protected virtual void _cbFromWazaListWindow(ListWindowBase.ActionType act) {} // 0x00E034A0-0x00E034D0
	protected override void _enableWindow() {} // 0x00E03860-0x00E03890
	private void _selectPokemonList() {} // 0x00E032C0-0x00E034A0
	private void _openWazaWindow() {} // 0x00E03890-0x00E03C50
	private void _startWazaWindow() {} // 0x00E03C50-0x00E03C90
	private void _updateWazaDetail(bool bForce = false /* Metadata: 0x00613850 */) {} // 0x00E03760-0x00E03860
	private void _endWazaList() {} // 0x00E034D0-0x00E03760
	private void _openWindow() {} // 0x00E03C90-0x00E03DD0
	private void _continueWindow() {} // 0x00E03DD0-0x00E03E10
	protected override void Update() {} // 0x00E03E10-0x00E03E70
}

