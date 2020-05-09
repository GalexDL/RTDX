/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIPokemonLevelUpDialog : UIManagerBase // TypeDefIndex: 7417
{
	// Fields
	private DialogWindow dialogWindow_; // 0x20

	// Nested types
	public class DialogWindow : UIWindowBase // TypeDefIndex: 7418
	{
		// Fields
		private UIFaceWindow pokemonFace_; // 0x30
		private IPokemonStatus status_; // 0x38
		private bool bHaveSugowaza_; // 0x40
		private int nAnimCount_; // 0x44
		private int nAnimPlayCount_; // 0x48

		// Constructors
		public DialogWindow() {} // 0x00C931D0-0x00C931E0

		// Methods
		public virtual void Init(GameObject root, LevelUpDialogInParameter levelUpParam) {} // 0x00C936B0-0x00C94F00
		private void _cbAnime(UIAnimationBase.ActionType act) {} // 0x00C94F00-0x00C95010
		// [IteratorStateMachine] // 0x0064F310-0x0064F380
		public IEnumerator ShowFlow() => default; // 0x00C935B0-0x00C93620
	}

	// Constructors
	public UIPokemonLevelUpDialog() {} // 0x00C93310-0x00C93320

	// Methods
	private void Start() {} // 0x00C92FC0-0x00C92FD0
	private void Update() {} // 0x00C92FD0-0x00C92FE0
	public static UIPokemonLevelUpDialog Create() => default; // 0x00C92FE0-0x00C93170
	public void Construct() {} // 0x00C93170-0x00C931D0
	public void Destruct() {} // 0x00C931E0-0x00C93260
	// [IteratorStateMachine] // 0x0062BF40-0x0062BFB0
	public IEnumerator MainFlow(LevelUpDialogInParameter levelUpParam, Action cb = null) => default; // 0x00C93260-0x00C932E0
}

