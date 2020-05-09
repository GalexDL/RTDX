/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIWorldMapSet : UIManagerBase // TypeDefIndex: 7979
{
	// Fields
	private Index[] mapDungeonIndex; // 0x20
	private string[] sTokenMapList; // 0x28
	private float fittingScale_; // 0x30
	private GameObject objMap_; // 0x38
	private Vector2 basePosition_; // 0x40
	private Vector2 currentPosition_; // 0x48
	private Vector2 targetPosition_; // 0x50
	private Vector2 vector_; // 0x58
	private int moveCount_; // 0x60
	private float baseScale_; // 0x64
	private float rangeScale_; // 0x68
	private int scaleCount_; // 0x6C
	private bool bExpandMode_; // 0x70
	private bool bDirty_; // 0x71
	private GameObject objPointer_; // 0x78

	// Nested types
	private enum MoveCount // TypeDefIndex: 7980
	{
		Position = 10,
		Scale = 10
	}

	// Constructors
	public UIWorldMapSet() {} // 0x00B39090-0x00B3A520

	// Methods
	private void Start() {} // 0x00B38280-0x00B38290
	private void Update() {} // 0x00B38290-0x00B382E0
	public static UIWorldMapSet Create() => default; // 0x00B2AC70-0x00B2ADD0
	public void Construct() {} // 0x00B385B0-0x00B38940
	public void SetVisible(bool bVisible) {} // 0x00B38940-0x00B38B70
	public void Destruct() {} // 0x00B2AF10-0x00B2AF90
	private GameObject _getMapPoint(Index dgIndex) => default; // 0x00B38B70-0x00B38CA0
	public void VisibleMap(Index dgIndex, bool bVisible) {} // 0x00B325E0-0x00B32690
	public void VisiblePointer(bool bVisible) {} // 0x00B38CA0-0x00B38CB0
	// [IteratorStateMachine] // 0x0062FB60-0x0062FBD0
	public IEnumerator OpenScreen() => default; // 0x00B32690-0x00B32700
	// [IteratorStateMachine] // 0x0062FBD0-0x0062FC40
	public IEnumerator CloseScreen() => default; // 0x00B38CE0-0x00B38D50
	// [IteratorStateMachine] // 0x0062FC40-0x0062FCB0
	public IEnumerator OpenPointer() => default; // 0x00B31460-0x00B314D0
	// [IteratorStateMachine] // 0x0062FCB0-0x0062FD20
	public IEnumerator OpenDungeonName(Index dgIndex) => default; // 0x00B314D0-0x00B31550
	// [IteratorStateMachine] // 0x0062FD20-0x0062FD90
	public IEnumerator CloseDungeonName() => default; // 0x00B38DE0-0x00B38E50
	public void SetMapPosition(Index dgIndex, bool bQuick) {} // 0x00B2EA50-0x00B2EBA0
	public void SetMapScale(bool bExpand, bool bForce = false /* Metadata: 0x00613BFF */) {} // 0x00B38E80-0x00B38EC0
	public void SwitchMapScale() {} // 0x00B38EC0-0x00B38ED0
	private bool _move(bool bForce = false /* Metadata: 0x00613C00 */) => default; // 0x00B38400-0x00B385B0
	private bool _scale(bool bForce = false /* Metadata: 0x00613C01 */) => default; // 0x00B382E0-0x00B38400
	// [IteratorStateMachine] // 0x0062FD90-0x0062FE00
	public IEnumerator WorldMapView_Flow(Action cb = null) => default; // 0x00B2FD00-0x00B2FD80
	// [IteratorStateMachine] // 0x0062FE00-0x0062FE70
	public IEnumerator Newarrival_Flow(Index dgIndex) => default; // 0x00B32700-0x00B32780
	// [IteratorStateMachine] // 0x0062FE70-0x0062FEE0
	public IEnumerator MainFlow(Index dgIndex, Action cb = null) => default; // 0x00B38F30-0x00B38FB0
	// [IteratorStateMachine] // 0x0062FEE0-0x0062FF50
	public IEnumerator MainFlow(Action cb = null) => default; // 0x00B38FE0-0x00B39060
}

