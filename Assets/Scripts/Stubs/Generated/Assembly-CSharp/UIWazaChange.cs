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

internal class UIWazaChange : RenketsuWazaSingleListWindow // TypeDefIndex: 7769
{
	// Fields
	private ActionType act_; // 0x6C
	private bool bCancel_; // 0x70
	private IPokemonStatus pokemonStatus_; // 0x78
	private bool bOriginal_; // 0x80
	private int targetNo_; // 0x84
	private GameObject mainObj_; // 0x88
	private Index selectWazaIndex_; // 0x90
	private PokemonStatusWindow_NoMove pokemonCardWindow_; // 0x98
	private WazaStatusExplainWindow wazaDetailWindow_; // 0xA0

	// Nested types
	public enum ActionType_WazaChange // TypeDefIndex: 7770
	{
		None = 0,
		Decide = 1,
		Cancel = 2
	}

	public enum RememberCaptionType // TypeDefIndex: 7771
	{
		Remember = 0,
		Learn = 1
	}

	public class PokemonStatusWindow_NoMove : PokemonStatusCardWindow // TypeDefIndex: 7772
	{
		// Constructors
		public PokemonStatusWindow_NoMove() {} // 0x00DD01C0-0x00DD01D0

		// Methods
		// [IteratorStateMachine] // 0x00651A40-0x00651AB0
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00DD1D60-0x00DD1DE0
	}

	// Constructors
	public UIWazaChange() {} // 0x00DCF730-0x00DCF740

	// Methods
	// [IteratorStateMachine] // 0x0062E760-0x0062E7D0
	public IEnumerator MainFlow(Action<ActionType> cbAction = null, Action<int> cbSelectNum = null, Action dest = null) => default; // 0x00DCF420-0x00DCF4A0
	public static UIWazaChange Create(GameObject mainObj, IPokemonStatus pokemonStatus, bool bOriginal, Index selectWazaIndex, int targetNo = 0 /* Metadata: 0x00613A22 */) => default; // 0x00DCF4D0-0x00DCF730
	public void Destruct() {} // 0x00DCFC70-0x00DCFD30
	public void _cbFromListWindow(ActionType act) {} // 0x00DCFD30-0x00DCFD60
	public void SetRememberCaption(RememberCaptionType type) {} // 0x00DCFD60-0x00DCFE90
	private void FaceSet() {} // 0x00DCF740-0x00DCFC70
	public void InitSingleFaceWindow(GameObject obj, out GameObject original, out GameObject face) {
		original = default;
		face = default;
	} // 0x00DCFE90-0x00DD01C0
	private void FaceStateOff(GameObject obj) {} // 0x00DD01D0-0x00DD02D0
	public override void Update() {} // 0x00DD02D0-0x00DD0310
	protected override bool _decide() => default; // 0x00DD0310-0x00DD0370
	protected override bool _doUp() => default; // 0x00DD0370-0x00DD03F0
	protected override bool _doDown() => default; // 0x00DD03F0-0x00DD0470
	public void UpdateWazaInfo(GameObject mainObj, Index waza) {} // 0x00DD0470-0x00DD0D80
	private void _setStatusGage(GameObject obj, int power, int addPower, bool bPowerMax, bool bFit = true /* Metadata: 0x00613A26 */) {} // 0x00DD0D80-0x00DD1220
	public static void WazaChange(IPokemonStatus status, int oldWazaId, Index newWazaIndex) {} // 0x00DD1220-0x00DD15A0
}

