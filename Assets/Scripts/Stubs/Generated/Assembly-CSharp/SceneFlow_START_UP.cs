/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class SceneFlow_START_UP : ISceneFlow // TypeDefIndex: 8026
{
	// Fields
	private bool bEndFlag_; // 0x10

	// Constructors
	public SceneFlow_START_UP() {} // 0x00CB6490-0x00CB64A0

	// Methods
	// [IteratorStateMachine] // 0x006301F0-0x00630260
	public IEnumerator MainFlow() => default; // 0x00CB6C00-0x00CB6C70
	public void OnEndRequest() {} // 0x00CB6CA0-0x00CB6CB0
	// [IteratorStateMachine] // 0x00630260-0x006302D0
	public IEnumerator NewGame_() => default; // 0x00CB6CB0-0x00CB6D20
	// [IteratorStateMachine] // 0x006302D0-0x00630340
	public IEnumerator ContinueGameGr_() => default; // 0x00CB6D50-0x00CB6DC0
	// [IteratorStateMachine] // 0x00630340-0x006303B0
	public IEnumerator ContinueGameDg_() => default; // 0x00CB6DF0-0x00CB6E60
	// [IteratorStateMachine] // 0x006303B0-0x00630420
	public IEnumerator ContinueGameDgGiveup_() => default; // 0x00CB6E90-0x00CB6F00
	// [IteratorStateMachine] // 0x00630420-0x00630490
	public IEnumerator ContinueGameDgRevival_() => default; // 0x00CB6F30-0x00CB6FA0
	// [IteratorStateMachine] // 0x00630490-0x00630500
	public IEnumerator Perippaa_(Action setReviveCb) => default; // 0x00CB6FD0-0x00CB7050
	// [IteratorStateMachine] // 0x00630500-0x00630570
	public IEnumerator PerippaaDungeon_(DungeonParameter dungeonParameter, Action<bool> CbSuspended) => default; // 0x00CB7080-0x00CB7100
	// [IteratorStateMachine] // 0x00630570-0x006305E0
	public IEnumerator PlayGameFlowData_(bool bResume) => default; // 0x00CB7130-0x00CB71B0
}

