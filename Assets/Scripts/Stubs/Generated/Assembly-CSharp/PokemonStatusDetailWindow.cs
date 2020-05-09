/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.item;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonStatusDetailWindow : PokemonStatusWindowBase // TypeDefIndex: 6331
{
	// Fields
	protected RenketsuWazaListWindow wazaListWindow_; // 0x38
	private EvolutionInfoState evolutionInfoState_; // 0x40
	private UIToken.UITokenCache rooUiTokenCache_; // 0x48

	// Properties
	public EvolutionInfoState EvolutionInfoState_ { set {} } // 0x00C53950-0x00C53960

	// Nested types
	public enum EvolutionInfoState // TypeDefIndex: 6332
	{
		NONE = 0,
		EVO_NORMAL = 1,
		EVO_SELECT = 2
	}

	// Constructors
	public PokemonStatusDetailWindow() {} // 0x00C571B0-0x00C571C0

	// Methods
	public override void Init(GameObject root) {} // 0x00C53960-0x00C53A20
	public static void UpdateFace(GameObject faceObj, IPokemonStatus status, EvolutionInfoState infoState, Index equipItem = Index.NONE /* Metadata: 0x00612C17 */) {} // 0x00C53A30-0x00C53AE0
	public static void UpdateFace(UIToken.UITokenCache uitokenCache, IPokemonStatus status, EvolutionInfoState infoState, Index equipItem = Index.NONE /* Metadata: 0x00612C1B */) {} // 0x00C53AE0-0x00C55B60
	public static void UpdateFace_Evo(UIToken.UITokenCache uitokenCache, IPokemonStatus status, EvolutionInfoState infoState, Index equipItem = Index.NONE /* Metadata: 0x00612C1F */) {} // 0x00C55B60-0x00C569D0
	public void UpdateWindow(IPokemonStatus status, bool bForce = false /* Metadata: 0x00612C23 */) {} // 0x00C569D0-0x00C56B40
	public void UpdateWindow_Evo(IPokemonStatus status, bool bForce = false /* Metadata: 0x00612C24 */) {} // 0x00C56B40-0x00C56BA0
	public static void StatusColorChange(GameObject faceObj, IPokemonStatus pokemonStatus, GummyAndSweetsUpStatus status, bool before) {} // 0x00C56BA0-0x00C571B0
}

