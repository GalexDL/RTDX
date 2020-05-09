/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.item;
using Const.pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FlowEvolution : FlowPlay // TypeDefIndex: 5273
{
	// Fields
	public IPokemonWarehouseStatus evolutionExecutionPokemon; // 0x90
	private ActAsset_Chara targetChara_; // 0x98
	private ActObjCharactor objChar_; // 0xA0
	private UIEvolution.States nowStates; // 0xA8
	public int nextEvoIndex; // 0xAC
	private ActAsset_Chara chara; // 0xB0
	private IPokemonWarehouseStatus selectPokemonWarehouseStatus; // 0xB8
	public MenuState menuState_; // 0xC0
	private UIEvolution menu_; // 0xC8
	private PokemonStatus nukeninStatus_; // 0xD0
	private CameraWork cameraWork_; // 0xD8

	// Properties
	public UIEvolution.States NowStates { get => default; set {} } // 0x00814A50-0x00814A60 0x00814A40-0x00814A50
	public IPokemonWarehouseStatus SelectPokemonWarehouseStatus { get => default; set {} } // 0x00814D30-0x00814D40 0x00814D40-0x00814D50

	// Nested types
	public enum MenuState // TypeDefIndex: 5274
	{
		Normal = 0,
		SecondOpen = 1,
		SecondClose = 2,
		DecideForFirst = 3
	}

	public class CameraWork // TypeDefIndex: 5275
	{
		// Fields
		public bool isFirst; // 0x10
		public Vector3 lastPos; // 0x14
		public Quaternion lastRot; // 0x20
		public float lastFov; // 0x30

		// Constructors
		public CameraWork() {} // 0x00814AF0-0x00814B00
	}

	private enum EndType // TypeDefIndex: 5276
	{
		High = 0,
		Low = 1
	}

	// Constructors
	private FlowEvolution() {} // 0x00814A60-0x00814AF0

	// Methods
	public static FlowEvolution Create() => default; // 0x00814B00-0x00814BD0
	// [IteratorStateMachine] // 0x0061E930-0x0061E9A0
	public IEnumerator SetEvolutionPokemon(Const.creature.Index index, string targetObjName, bool before, GenderType genderType, bool scarfVisible = false /* Metadata: 0x00611225 */) => default; // 0x00814BD0-0x00814C80
	public void UnloadActObj(string targetObjName) {} // 0x00814CB0-0x00814D30
	// [IteratorStateMachine] // 0x0061E9A0-0x0061EA10
	public override IEnumerator Play(UIManagerBase menuBase, FlowPlayParam param) => default; // 0x00814D50-0x00814DD0
	private void MoveNext_CheckUseItemCount() {} // 0x00814E00-0x00814E80
	// [IteratorStateMachine] // 0x0061EA10-0x0061EA80
	private IEnumerator MoveNext_Reward_NUKENIN() => default; // 0x00814E80-0x00814EF0
	private void MoveNext_IsNotTSUCHININ() {} // 0x00814F20-0x00814FB0
	private void MoveNext_CheckEvoPokemonCount() {} // 0x00814FB0-0x008150F0
	public override void OpenFaceWindow(FlowPlayType playType) {} // 0x008150F0-0x00815100
	private void MoveNext_CheckCameraType_Before() {} // 0x00815100-0x008151E0
	private void MoveNext_CheckCameraType_After() {} // 0x008151E0-0x008152C0
	private void ConfirmEvolution_MoveNext() {} // 0x008152C0-0x00815E80
	protected override string GetPokemonData_String() => default; // 0x00815E80-0x00815EE0
	protected override Const.creature.Index GetKindData() => default; // 0x00815EE0-0x00815FD0
	protected override Const.item.Index GetItemData() => default; // 0x00815FD0-0x00815FE0
	protected override string GetValueData() => default; // 0x00815FE0-0x00816060
	private void ResetCamera(string targetSymbol) {} // 0x00816060-0x008161E0
	// [IteratorStateMachine] // 0x0061EA80-0x0061EAF0
	private IEnumerator MoveCamera(string targetSymbol, EndType endType, float speed = 0.5f /* Metadata: 0x00611226 */, Action<bool> cb = null) => default; // 0x008161E0-0x00816280
	// [IteratorStateMachine] // 0x0061EAF0-0x0061EB60
	private IEnumerator FadeIn(float time, Action<bool> cb = null) => default; // 0x008162B0-0x00816330
	// [IteratorStateMachine] // 0x0061EB60-0x0061EBD0
	private IEnumerator EnterProduction() => default; // 0x00816360-0x008163D0
	private void MoveNext_Fadeout_BGM() {} // 0x00816400-0x00816490
	private void MoveNext_Fadeout_BGM_Short() {} // 0x00816490-0x00816520
	// [IteratorStateMachine] // 0x0061EBD0-0x0061EC40
	private IEnumerator MoveNext_WaitAnd_ME_EVOLUTION() => default; // 0x00816520-0x00816590
	private void MoveNext_Play_BGM_EVE_LEGEND() {} // 0x008165C0-0x00816660
	// [IteratorStateMachine] // 0x0061EC40-0x0061ECB0
	private IEnumerator EvolutionBeforeProduction() => default; // 0x00816660-0x008166D0
	// [IteratorStateMachine] // 0x0061ECB0-0x0061ED20
	private IEnumerator EvolutionAfterProduction() => default; // 0x00816700-0x00816770
	// [IteratorStateMachine] // 0x0061ED20-0x0061ED90
	private IEnumerator ColoringVisible(string targetObjName, Action colorCb = null) => default; // 0x008167A0-0x00816820
	private void PlayMotion(string targetObjName, Action cb = null) {} // 0x00816850-0x00816920
	private void MoveNext_CheckScarf() {} // 0x00816920-0x00816A30
	private void MoveNext_IsHero() {} // 0x00816A30-0x00816AD0
	// [IteratorStateMachine] // 0x0061ED90-0x0061EE00
	private IEnumerator MoveNext_OpenEvolutionParamInfo() => default; // 0x00816AD0-0x00816B40
	// [IteratorStateMachine] // 0x0061EE00-0x0061EE70
	private IEnumerator MoveNext_CloseEvolutionParamInfo() => default; // 0x00816B70-0x00816BE0
}

