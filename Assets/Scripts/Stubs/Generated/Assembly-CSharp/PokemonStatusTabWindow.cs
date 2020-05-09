/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.creature;
using Const.item;
using Const.sugowaza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonStatusTabWindow : UIWindowBase // TypeDefIndex: 6333
{
	// Fields
	private TabWindowBase tabWindow_; // 0x30
	private PokemonStatusDetailWindow statusDetailWindow_; // 0x38
	private PokemonStatusTokuchoWindow statusTokuchoWindow_; // 0x40
	private UIFaceWindow statusFaceWindow_; // 0x48
	private CallbackAction callbackFunc_; // 0x50
	private float time_; // 0x58

	// Properties
	protected TabWindowBase TabWindow { get => default; } // 0x00C571E0-0x00C571F0 
	public PokemonStatusDetailWindow.EvolutionInfoState EvolutionInfoState_ { set {} } // 0x00C588E0-0x00C588F0

	// Nested types
	public enum ActionType // TypeDefIndex: 6334
	{
		TabChangeStart = 0,
		TabChangeEnd = 1
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6335; 0x00C57A40-0x00C57DF0

	public class StatusUpReturnData // TypeDefIndex: 6336
	{
		// Fields
		public int upValue; // 0x10
		public string token; // 0x18
		public TextIDHash textId; // 0x20

		// Constructors
		public StatusUpReturnData() {} // 0x00C59E00-0x00C59E10
	}

	// Constructors
	public PokemonStatusTabWindow() {} // 0x00C5B850-0x00C5B860

	// Methods
	public override void Init(GameObject objTop) {} // 0x00C571F0-0x00C57710
	public void ChangeFace(FACE_TYPE type) {} // 0x00C57830-0x00C57840
	public void ResetActionListener() {} // 0x00C57840-0x00C57850
	public void RegisterActionListener(CallbackAction cb) {} // 0x00C57850-0x00C57940
	public void UnregisterActionListener(CallbackAction cb) {} // 0x00C57940-0x00C57A30
	public void callAction(ActionType action) {} // 0x00C57A30-0x00C57A40
	private void _cbFromTabWindow(TabWindowBase.ActionType act) {} // 0x00C57DF0-0x00C57FC0
	private void _cbFromStatusWindow(PokemonStatusWindowBase.ActionType act) {} // 0x00C57FC0-0x00C57FE0
	protected virtual void TokuchoChange() {} // 0x00C57FE0-0x00C58040
	protected override void _doUpdate() {} // 0x00C58080-0x00C58090
	public int GetCurrentTabIndex() => default; // 0x00C58090-0x00C580A0
	public void SetCurrentTabIndex(int tabIndex) {} // 0x00C580A0-0x00C580B0
	// [IteratorStateMachine] // 0x00625C50-0x00625CC0
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00C580B0-0x00C58130
	public override bool IsOpened() => default; // 0x00C58160-0x00C58180
	// [IteratorStateMachine] // 0x00625CC0-0x00625D30
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00C58180-0x00C58200
	public override bool IsClosed() => default; // 0x00C58230-0x00C58250
	// [IteratorStateMachine] // 0x00625D30-0x00625DA0
	public IEnumerator ShowWindow(Action cb = null) => default; // 0x00C58250-0x00C582D0
	// [IteratorStateMachine] // 0x00625DA0-0x00625E10
	public IEnumerator HideWindow(Action cb = null) => default; // 0x00C58300-0x00C58380
	public void UpdateWindow(IPokemonStatus status, bool bForce = false /* Metadata: 0x00612C31 */) {} // 0x00C583B0-0x00C58400
	public void UpdateWindow_Evo(IPokemonStatus status, bool bForce = false /* Metadata: 0x00612C32 */) {} // 0x00C584D0-0x00C58540
	public void SetFace(IPokemonStatus status, Const.creature.Index faceIndexForce = Const.creature.Index.NONE /* Metadata: 0x00612C33 */) {} // 0x00C58540-0x00C587E0
	public void SwitchFavorite(IPokemonStatus status) {} // 0x00C587E0-0x00C588E0
	private int GetUpValue(int nowStatus, int upValue, out int addValue, bool hp = false /* Metadata: 0x00612C37 */) {
		addValue = default;
		return default;
	} // 0x00C588F0-0x00C58920
	public void GummyStatusUp(IPokemonStatus pokemonStatus, Const.item.Index gummyIndex, Action<Const.sugowaza.Index, UICampMenu.Status> cb) {} // 0x00C58920-0x00C592A0
	public void ParameterStatusUp(IPokemonStatus pokemonStatus, Const.item.Index itemIndex, Action cb = null) {} // 0x00C598D0-0x00C59DE0
	public StatusUpReturnData StatusUp(IPokemonStatus pokemonStatus, string token, bool bigUp, GummyAndSweetsUpStatus upStatus, bool gummy, int upValueForce = 0 /* Metadata: 0x00612C38 */) => default; // 0x00C592D0-0x00C596C0
	public void GummySugowaza(IPokemonStatus pokemonStatus, bool bNew, GameObject effect, Action cb, Action addEffect = null) {} // 0x00C59E10-0x00C5A160
	// [IteratorStateMachine] // 0x00625E10-0x00625E80
	private IEnumerator SetSugowaza_Adjust(IPokemonStatus pokemonStatus, Action addEffect = null) => default; // 0x00C5B230-0x00C5B2B0
	public void SetSugowazaExplain(Const.sugowaza.Index sugowazaIndex) {} // 0x00C5B2E0-0x00C5B2F0
	private void Wrapper(GameObject status, IPokemonStatus pokemonStatus, GummyAndSweetsUpStatus upStatus, Action cb = null) {} // 0x00C5B5B0-0x00C5B600
	// [IteratorStateMachine] // 0x00625E80-0x00625EF0
	private IEnumerator StatusUpMessage_Gummy(IPokemonStatus pokemonStatus, int upValue, bool isBig, GummyAndSweetsUpStatus status, TextIDHash textId, Action cb = null) => default; // 0x00C5B600-0x00C5B6A0
	// [IteratorStateMachine] // 0x00625EF0-0x00625F60
	private IEnumerator StatusUpMessage_parameter(IPokemonStatus pokemonStatus, int upValue, GummyAndSweetsUpStatus status, TextIDHash textId, Action cb = null) => default; // 0x00C5B6D0-0x00C5B770
	public void GameSaveDataSave() {} // 0x00C596C0-0x00C59730
	// [IteratorStateMachine] // 0x00625F60-0x00625FD0
	private IEnumerator DontStatusUpMessage(IPokemonStatus status, Action cb = null) => default; // 0x00C59850-0x00C598D0
	public void TabChangeToStatus() {} // 0x00C59730-0x00C59850
	private void TabChangeToTokutyou() {} // 0x00C5B100-0x00C5B230
	public void SugowazaExplainViewSet() {} // 0x00C5B7D0-0x00C5B820
}

