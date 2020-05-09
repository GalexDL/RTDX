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

public class RenketsuWazaSingleListWindow : RenketsuWazaListWindow // TypeDefIndex: 8006
{
	// Fields
	private List<GameObject> extCursor_; // 0x60
	private int wazaCount_; // 0x68

	// Constructors
	public RenketsuWazaSingleListWindow() {} // 0x00A03550-0x00A035C0

	// Methods
	public void AddList(GameObject face, GameObject cursor, Index wazaIndex, IPokemonStatus status = null, bool bOriginal = false /* Metadata: 0x00613C1F */) {} // 0x00A01E90-0x00A02100
	protected virtual bool GetEnable(Index wazaIndex) => default; // 0x00A02100-0x00A02110
	protected override void _initMenu(IPokemonStatus pokemonStatus, bool bOriginal) {} // 0x00A02110-0x00A02C10
	// [IteratorStateMachine] // 0x0062FFC0-0x00630030
	public IEnumerable<int> GetWazaStatusId() => default; // 0x00A02C10-0x00A02C90
	public override int GetFocusWazaStatusId() => default; // 0x00A02CD0-0x00A02E90
	protected override void _cursorVisible(bool bVisible) {} // 0x00A02E90-0x00A03550
}

