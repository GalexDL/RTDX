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

public class UIWazaDungeonMenu : UIManagerBase // TypeDefIndex: 7777
{
	// Fields
	private CommonScreen commonScreen_; // 0x20
	private bool bCancel_; // 0x28
	private bool bDecide; // 0x29
	private bool bSelect; // 0x2A
	private bool bAnimation; // 0x2B
	private bool bChanged; // 0x2C
	private bool[] bWaza; // 0x30
	private int nowSelect; // 0x38
	private GameObject button_go; // 0x40
	private GameObject[] buttons; // 0x48
	private GameObject[] selects; // 0x50
	private GameObject[] focuses; // 0x58
	public IPokemonStatus pokemonStatus_; // 0x60
	private RenketsuWazaSingleListWindowLocal wazaListWindow_; // 0x68
	private WazaStatusExplainWindow wazaDetailWindow_; // 0x70
	private PokemonStatusCardWindow[] pokemonCardWindow_; // 0x78
	private PokemonPartyListWindow wazaPokemonListWindow_; // 0x80
	private GameObject instance_; // 0x88
	private GameObject objGuide_; // 0x90
	private bool isDisable; // 0x98
	private int nowSelectNo; // 0x9C
	private bool isDecided; // 0xA0
	protected bool bSingleCall; // 0xA1
	private bool is_exit; // 0xA2
	private bool isOpenButtonSet; // 0xA3
	private bool isPokemonDecide; // 0xA4
	private bool isPokemonSelect; // 0xA5

	// Nested types
	private class RenketsuWazaSingleListWindowLocal : RenketsuWazaSingleListWindow // TypeDefIndex: 7778
	{
		// Constructors
		public RenketsuWazaSingleListWindowLocal() {} // 0x00DD22A0-0x00DD22B0

		// Methods
		protected override bool _decide() => default; // 0x00DD4EF0-0x00DD4F70
	}

	// Constructors
	public UIWazaDungeonMenu() {} // 0x00DD3E30-0x00DD3EE0

	// Methods
	public static UIWazaDungeonMenu Create() => default; // 0x00DD2030-0x00DD2190
	public void Construct(GameObject inst, IPokemonStatus status) {} // 0x00DD2190-0x00DD22A0
	public void Init() {} // 0x00DD22C0-0x00DD29E0
	public void Destruct() {} // 0x00DD2CA0-0x00DD2D90
	public void Init(FlowPlay instance, GameObject mainObj) {} // 0x00DD2D90-0x00DD2DA0
	public void SetSingleCall() {} // 0x00DD2DA0-0x00DD2DB0
	// [IteratorStateMachine] // 0x0062E7D0-0x0062E840
	public IEnumerator MainFlow(Action<bool> resultCb) => default; // 0x00DD2DB0-0x00DD2E30
	public void Update() {} // 0x00DD2E60-0x00DD2F00
	private void redraw() {} // 0x00DD22B0-0x00DD22C0
	private void _doInput() {} // 0x00DD2F00-0x00DD3420
	// [IteratorStateMachine] // 0x0062E840-0x0062E8B0
	public IEnumerator WazaButtonSetFlow() => default; // 0x00DD3440-0x00DD34B0
	private bool _doUp() => default; // 0x00DD34E0-0x00DD34F0
	private bool _doDown() => default; // 0x00DD34F0-0x00DD3500
	private bool _doLeft() => default; // 0x00DD3500-0x00DD3510
	private bool _doRight() => default; // 0x00DD3510-0x00DD3520
	private bool _doDecide() => default; // 0x00DD3520-0x00DD3530
	private bool _doCancel() => default; // 0x00DD3430-0x00DD3440
	private bool _doExit() => default; // 0x00DD3530-0x00DD3550
	private bool _doWazaExecute(int waza_no) => default; // 0x00DD3550-0x00DD35E0
	private bool _doWazaChangeOnOff(int waza_no) => default; // 0x00DD35E0-0x00DD39A0
	private void _cbFromPokemonListWindow(ListWindowBase.ActionType act) {} // 0x00DD39A0-0x00DD3AB0
	private void _cbFromWazaListWindow(ListWindowBase.ActionType act) {} // 0x00DD3AB0-0x00DD3B50
	private void _endWazaList() {} // 0x00DD3B50-0x00DD3B60
	private void _updateWazaDetail(bool bForce = false /* Metadata: 0x00613A3B */) {} // 0x00DD3B60-0x00DD3BB0
	private bool checkHenshin(int select) => default; // 0x00DD3BB0-0x00DD3E30
	private void setPokemonCards(int select) {} // 0x00DD29E0-0x00DD2CA0
}

