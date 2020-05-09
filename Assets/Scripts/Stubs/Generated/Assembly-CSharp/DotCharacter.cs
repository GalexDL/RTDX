/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DotCharacter : MonoBehaviour // TypeDefIndex: 4846
{
	// Fields
	private GraphicsSystem.CharacterDatabaseParameter baseParameter_; // 0x18
	private uint gfxSymbol_; // 0x20
	private GameObject dotBody_; // 0x28
	private GameObject dotOffsetNode_; // 0x30
	private Direction direction_; // 0x38
	private bool bPositionDirtyFlag_; // 0x3C
	private bool bSetup_; // 0x3D

	// Nested types
	public enum Direction // TypeDefIndex: 4847
	{
		Left = 0,
		Right = 1
	}

	// Constructors
	public DotCharacter() {} // 0x007B6340-0x007B6350

	// Methods
	public static DotCharacter Create(Index index, FormType form, Direction direction, bool attach = true /* Metadata: 0x00610BA5 */) => default; // 0x007B5BF0-0x007B5CF0
	public static DotCharacter Create(uint gfxSymbol, Direction direction) => default; // 0x007B5D90-0x007B5E30
	public static void Destroy(DotCharacter obj) {} // 0x007B5F80-0x007B6090
	private void Initialize(Index index, FormType form, Direction direction, bool attach = true /* Metadata: 0x00610BA6 */) {} // 0x007B5CF0-0x007B5D90
	private void Initialize(uint gfxSymbol, Direction direction, bool attach = true /* Metadata: 0x00610BA7 */) {} // 0x007B5E30-0x007B5F80
	public void ChangePriority(CommonCanvas.UIPriority priority) {} // 0x007B6090-0x007B6160
	private void OnDestroy() {} // 0x007B6160-0x007B6290
	// [IteratorStateMachine] // 0x0061C1E0-0x0061C250
	private IEnumerator Start() => default; // 0x007B6290-0x007B6300
	private void Update() {} // 0x007B6330-0x007B6340
}

