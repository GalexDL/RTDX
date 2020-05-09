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

public class UIPokemonConfirmWindow : UIWindowBase // TypeDefIndex: 7489
{
	// Fields
	private UIFaceWindow pokemonFace_; // 0x30
	private IPokemonStatus status_; // 0x38
	private bool bHaveSugowaza_; // 0x40

	// Constructors
	public UIPokemonConfirmWindow() {} // 0x00C92C20-0x00C92C30

	// Methods
	public virtual void Init(GameObject root, IPokemonStatus status) {} // 0x00C924F0-0x00C92A10
	// [IteratorStateMachine] // 0x0062C850-0x0062C8C0
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00C92A10-0x00C92A90
	// [IteratorStateMachine] // 0x0062C8C0-0x0062C930
	public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00C92AC0-0x00C92B40
	// [IteratorStateMachine] // 0x0062C930-0x0062C9A0
	public virtual IEnumerator BreakupCloseWindow(Action cb = null) => default; // 0x00C92B70-0x00C92BF0
}

