/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.ability;
using Const.sugowaza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonStatusTokuchoWindow : PokemonStatusWindowBase // TypeDefIndex: 6351
{
	// Fields
	private ExplainView explainView_; // 0x38
	private Const.ability.Index abilityIndex_; // 0x40
	private Const.sugowaza.Index sugowazaIndex_; // 0x44
	private bool bViewAbility_; // 0x48

	// Nested types
	private class ExplainView : DetailWindowBase // TypeDefIndex: 6352
	{
		// Constructors
		public ExplainView() {} // 0x00C5D210-0x00C5D220
	}

	// Constructors
	public PokemonStatusTokuchoWindow() {} // 0x00C57710-0x00C57720

	// Methods
	public override void Init(GameObject root) {} // 0x00C5D0C0-0x00C5D210
	private void _setViewMode(bool bViewAbility) {} // 0x00C5D220-0x00C5D5C0
	public void SetSugowazaExplain(Const.sugowaza.Index sugowazaIndex) {} // 0x00C5B2F0-0x00C5B5B0
	public void ChangeView() {} // 0x00C58040-0x00C58080
	public void ChangeToSugowazaView() {} // 0x00C5B820-0x00C5B850
	public static void UpdateFace(GameObject faceObj, IPokemonStatus status) {} // 0x00C5A170-0x00C5B100
	public void UpdateWindow(IPokemonStatus status, bool bForce = false /* Metadata: 0x00612C44 */) {} // 0x00C58400-0x00C584D0
	protected override void _doUpdate() {} // 0x00C5D5C0-0x00C5D670
}

