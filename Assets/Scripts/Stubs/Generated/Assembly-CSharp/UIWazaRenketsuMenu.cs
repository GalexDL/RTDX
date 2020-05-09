/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SpecialAnim;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIWazaRenketsuMenu : UIManagerBase // TypeDefIndex: 7902
{
	// Fields
	private UIWazaMain.WazaStatusExplainWindow_Wazaya wazaDetailWindow_; // 0x20
	private UIWazaMain.WazaStatusExplainWindow_Wazaya wazaExplanationWindow_; // 0x28
	private string[] actionNames; // 0x30
	private Anim<SpViewState> anim; // 0x38
	private Details_Waza_Set wazaSet_; // 0x40
	private CommonScreen commonScreen_; // 0x48
	private RenketsuWazaSingleListWindowLocal wazaRenketsuListWindow_; // 0x50
	private RenketsuWazaListWindowLocal wazaListWindow_; // 0x58
	private RenketsuWazaShowWindow wazaListWindowRenketsu_; // 0x60
	private BunkaiWazaShowWindow wazaListWindowBunkai_; // 0x68
	private RenketsuButton buttonRenketsu_; // 0x70
	private RenketsuButton buttonOmakase_; // 0x78
	private RenketsuButton buttonBunkai_; // 0x80
	private ActionType act_; // 0x88
	private IPokemonStatus pokemonStatus_; // 0x90
	private GameObject instance_; // 0x98
	private bool bCreateInstance_; // 0xA0
	private List<int> renketsuList_; // 0xA8
	private MenuMode mode_; // 0xB0
	private UIWazaMain wazaMain_; // 0xB8
	private bool bAnimationPlaying_; // 0xC0
	private static string[] aBoardToken; // 0x00
	private static int[] aBunkaiListTokenId; // 0x08

	// Nested types
	private enum SpViewState // TypeDefIndex: 7903
	{
		NONE = 0,
		RENKETSU_OPEN = 1,
		RENKETSU_CLOSE = 2
	}

	private class Details_Waza_Set : UIWindowBase // TypeDefIndex: 7904
	{
		// Constructors
		public Details_Waza_Set() {} // 0x00D59C70-0x00D59C80
	}

	private class RenketsuWazaSingleListWindowLocal : RenketsuWazaSingleListWindow // TypeDefIndex: 7905
	{
		// Fields
		private bool[] aSelect_; // 0x70

		// Constructors
		public RenketsuWazaSingleListWindowLocal() {} // 0x00D59BA0-0x00D59C00

		// Methods
		public void SetForbiddenRenketsuItemDisable(IPokemonStatus pokemonStatus, bool bForce) {} // 0x00D59D60-0x00D5A0B0
		public void ClearSelectState() {} // 0x00D5B630-0x00D5B6A0
		private int _getRenketsuListIndex(int wazaStatusId) => default; // 0x00D5C8A0-0x00D5CA00
		public int GetRenketsuTopWazaStatusId(int wazaStatusId) => default; // 0x00D5B520-0x00D5B5C0
		public bool IsRenketsuListSelect(int wazaStatusId) => default; // 0x00D5B5C0-0x00D5B630
		protected override bool _decide() => default; // 0x00D5CA00-0x00D5CB00
		public void UpdateFocusFace() {} // 0x00D5A0B0-0x00D5A7C0
		protected override bool _doYButton() => default; // 0x00D5CB00-0x00D5CB20
	}

	private class RenketsuWazaListWindowLocal : RenketsuWazaListWindow // TypeDefIndex: 7906
	{
		// Constructors
		public RenketsuWazaListWindowLocal() {} // 0x00D59C00-0x00D59C70

		// Methods
		public void SetSingleItemDisable(bool bForce) {} // 0x00D5AB20-0x00D5AD30
		protected override bool _doYButton() => default; // 0x00D5C880-0x00D5C8A0
	}

	private class RenketsuButton : BasicButtonWindow // TypeDefIndex: 7907
	{
		// Constructors
		public RenketsuButton() {} // 0x00D59C80-0x00D59C90

		// Methods
		public override void FaceEnable(bool bEnable) {} // 0x00D5C760-0x00D5C880
	}

	public enum MenuMode // TypeDefIndex: 7908
	{
		Renketsu = 0,
		Bunkai = 1
	}

	public enum ActionType // TypeDefIndex: 7909
	{
		None = 0,
		Decide = 1,
		Cancel = 2
	}

	// Constructors
	public UIWazaRenketsuMenu() {} // 0x00D5C0B0-0x00D5C1F0
	static UIWazaRenketsuMenu() {} // 0x00D5C1F0-0x00D5C430

	// Methods
	private void Renketsu_Open(Action cb = null) {} // 0x00D58890-0x00D58980
	private void Renketsu_Close(Action cb = null) {} // 0x00D58980-0x00D58A70
	public static UIWazaRenketsuMenu Create() => default; // 0x00D58A70-0x00D58C90
	public static UIWazaRenketsuMenu CreateForWazaMain(MenuMode mode) => default; // 0x00D4D4A0-0x00D4D6C0
	public void Construct(GameObject myInstance_, bool bCreateInstance = true /* Metadata: 0x00613BA1 */) {} // 0x00D58C90-0x00D58ED0
	public void Destruct() {} // 0x00D59C90-0x00D59D60
	public void Init(IPokemonStatus pokemonStatus, MenuMode mode) {} // 0x00D58ED0-0x00D59BA0
	// [IteratorStateMachine] // 0x0062EFF0-0x0062F060
	public IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00D4D6C0-0x00D4D740
	private void doUpdate() {} // 0x00D5AE30-0x00D5B060
	private void _showRenketsuList(GameObject objRenketsu) {} // 0x00D5A7C0-0x00D5A870
	private void _cbFromWazaListWindowForRenketsu(ListWindowBase.ActionType act) {} // 0x00D5B060-0x00D5B520
	private void _onRenketsuStart() {} // 0x00D5B6A0-0x00D5BA10
	private void _setBoardBunkai(int rowCount) {} // 0x00D5A870-0x00D5AB20
	private void _showBunkaiList(GameObject objRenketsu) {} // 0x00D5AD30-0x00D5AE00
	private void _cbFromWazaListWindowForBunkai(ListWindowBase.ActionType act) {} // 0x00D5BAD0-0x00D5BCB0
	private void _onBunkaiStart() {} // 0x00D5BCB0-0x00D5C050
	private void Start() {} // 0x00D5C050-0x00D5C060
	private void Update() {} // 0x00D5C060-0x00D5C0B0
}

