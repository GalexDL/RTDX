/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.sugowaza;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonStatusCardWindow : UIWindowBase // TypeDefIndex: 6326
{
	// Fields
	protected UIFaceWindow faceWindow_; // 0x30
	private bool bFaceFocus_; // 0x38
	private bool bFaceSelect_; // 0x39
	private bool bFaceEnable_; // 0x3A
	private Const.creature.Index formChangeIndex_; // 0x3C

	// Properties
	public bool FaceFocus { get => default; set {} } // 0x00C51F60-0x00C51F70 0x00C51F50-0x00C51F60
	public bool FaceSelect { get => default; set {} } // 0x00C51F80-0x00C51F90 0x00C51F70-0x00C51F80
	public bool FaceEnable { get => default; set {} } // 0x00C51FA0-0x00C51FB0 0x00C51F90-0x00C51FA0
	public Const.creature.Index FormChangeIndex { get => default; set {} } // 0x00C51FC0-0x00C51FD0 0x00C51FB0-0x00C51FC0

	// Constructors
	public PokemonStatusCardWindow() {} // 0x00C53410-0x00C53420

	// Methods
	public override void Init(GameObject root) {} // 0x00C51FD0-0x00C52160
	protected void setFaceIcon_(Const.creature.Index pokemonIndex, bool bFemale, Const.sugowaza.Index sugowazaIndex, UIFaceWindow.StateIconType stateIcon) {} // 0x00C52540-0x00C52660
	protected void activeFaceIcon_(bool bActive) {} // 0x00C52660-0x00C52710
	public void UpdateWindow(IPokemonStatus status, int id, IItem item, bool bForce = false /* Metadata: 0x00612C16 */) {} // 0x00C52710-0x00C532B0
	// [IteratorStateMachine] // 0x00625B70-0x00625BE0
	public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00C532B0-0x00C53330
	// [IteratorStateMachine] // 0x00625BE0-0x00625C50
	public virtual IEnumerator PlayEffect(Action cb = null) => default; // 0x00C53360-0x00C533E0
	public void UpdateFace() {} // 0x00C52160-0x00C52540
}

