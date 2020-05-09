/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.camp;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FlowCamp : FlowPlay // TypeDefIndex: 5258
{
	// Fields
	private Const.item.Index selectGummyIndex_; // 0x90
	private bool access; // 0x94
	public ContinueStatus continueStatus; // 0x98
	private UICampMenu.Status nowStates; // 0x9C
	private IPokemonWarehouseStatus selectPokemonWarehouseStatus; // 0xA0
	private ToActionType type; // 0xA8
	private Const.camp.Index selectCampIndex; // 0xAC
	private UICampMenu menu; // 0xB0

	// Properties
	public Const.item.Index SelectGummyIndex { get => default; set {} } // 0x00811C70-0x00811D20 0x00811D20-0x00811D30
	public bool Access { get => default; set {} } // 0x00811D30-0x00811D40 0x00811D40-0x00811D50
	public UICampMenu.Status NowStates { get => default; set {} } // 0x00811D60-0x00811D70 0x00811D50-0x00811D60
	public IPokemonWarehouseStatus SelectPokemonWarehouseStatus { get => default; set {} } // 0x00811E90-0x00811EA0 0x00811EA0-0x00811EB0
	public ToActionType Type { get => default; set {} } // 0x00811EB0-0x00811EC0 0x00811EC0-0x00811ED0
	public Const.camp.Index SelectCampIndex { get => default; set {} } // 0x00811ED0-0x00811EE0 0x00811EE0-0x00811EF0

	// Nested types
	public enum ContinueStatus // TypeDefIndex: 5259
	{
		NONE = 0,
		CAMP_SELECT = 1,
		POKEMON_SELECT = 2,
		CAMPIN_POKEMON_SELECT = 3,
		MAX = 4
	}

	public enum ToActionType // TypeDefIndex: 5260
	{
		NONE = 0,
		GUMMY = 1,
		ITEMUSE = 2,
		NICKNAME = 3,
		PART = 4,
		FAVORITE = 5
	}

	// Constructors
	private FlowCamp() {} // 0x00811D70-0x00811DE0

	// Methods
	public static FlowCamp Create() => default; // 0x00811DE0-0x00811E90
	// [IteratorStateMachine] // 0x0061E4D0-0x0061E540
	public override IEnumerator Play(UIManagerBase menuBase, FlowPlayParam param) => default; // 0x00811EF0-0x00811F70
	// [IteratorStateMachine] // 0x0061E540-0x0061E5B0
	protected IEnumerator End_IEnumrator() => default; // 0x00811FA0-0x00812010
	public override void OpenFaceWindow(FlowPlayType playType) {} // 0x00812040-0x00812050
	protected override string GetPokemonData_String() => default; // 0x00812050-0x008120C0
	private void MoveNext_IsFavorite_Camp() {} // 0x008120C0-0x00812160
	private void ActionSelect_MoveNext() {} // 0x00812160-0x00812200
	private void PartConfirm_MoveNext(UICampMenu menu) {} // 0x00812200-0x008122E0
	private void Favorite_MoveNext() {} // 0x008122E0-0x008122F0
	// [IteratorStateMachine] // 0x0061E5B0-0x0061E620
	private IEnumerator CheckMemberBeing_MoveNext(UICampMenu menu) => default; // 0x008122F0-0x00812370
	// [IteratorStateMachine] // 0x0061E620-0x0061E690
	protected override IEnumerator CloseCommon(Action cb = null) => default; // 0x008123A0-0x00812400
	protected override Const.item.Index GetItemData() => default; // 0x00812430-0x008124E0
}

