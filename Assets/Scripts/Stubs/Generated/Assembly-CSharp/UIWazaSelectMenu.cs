/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;
using Const.waza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIWazaSelectMenu : UIManagerBase // TypeDefIndex: 7034
{
	// Fields
	protected RenketsuWazaSingleListWindow listWindow_; // 0x20
	protected WazaStatusExplainWindow detailWindow_; // 0x28
	protected CommonScreen commonScreen_; // 0x30
	protected ActionType act_; // 0x38
	private IPokemonStatus status_; // 0x40
	private bool bDetailWindowClose_; // 0x48

	// Properties
	protected IPokemonStatus Status { get => default; } // 0x00D5D190-0x00D5D1A0 
	protected bool bDetailWindowClose { set {} } // 0x00D5D1A0-0x00D5D1B0

	// Nested types
	public enum ActionType // TypeDefIndex: 7035
	{
		Cancel = -1,
		None = 0,
		Decide = 1
	}

	// Constructors
	public UIWazaSelectMenu() {} // 0x00D5D8B0-0x00D5D8C0

	// Methods
	private void Start() {} // 0x00D5CB20-0x00D5CB30
	private void Update() {} // 0x00D5CB30-0x00D5CB80
	public static UIWazaSelectMenu Create() => default; // 0x00D5CB80-0x00D5CCE0
	public virtual void Construct() {} // 0x00D5CCE0-0x00D5CDC0
	public virtual void Destruct() {} // 0x00D5CDC0-0x00D5CE40
	protected virtual void _cbFromWazaListWindow(ListWindowBase.ActionType act) {} // 0x00D5CE40-0x00D5CEE0
	public void Init(IPokemonStatus status, bool objVisible = false /* Metadata: 0x00613267 */, int defaultIndex = 0 /* Metadata: 0x00613268 */) {} // 0x00D5D1B0-0x00D5D330
	protected virtual GameObject GetWazaDetailObj() => default; // 0x00D5D330-0x00D5D3C0
	protected void _updateWazaDetail(bool bForce = false /* Metadata: 0x0061326C */) {} // 0x00D5D140-0x00D5D190
	protected void _startWazaWindow() {} // 0x00D5D3C0-0x00D5D420
	private void _endWazaList(ActionType act) {} // 0x00D5CEE0-0x00D5D140
	// [IteratorStateMachine] // 0x00629BA0-0x00629C10
	public IEnumerator MainFlow(Action<Const.waza.Index> cb = null) => default; // 0x00D5D430-0x00D5D4B0
	public void CheckEnableParameterUp(Const.item.Index itemIndex) {} // 0x00D5D4E0-0x00D5D8B0
}

