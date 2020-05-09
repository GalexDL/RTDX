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

[ExecuteInEditMode] // 0x0060A410-0x0060A420
public class UIAskMenu : UIGeneralMenu // TypeDefIndex: 6428
{
	// Fields
	protected static string[] aMenuFramePrefab_; // 0x00
	protected Place place_; // 0x38
	protected static string[] aPlaceToken_; // 0x08
	protected static string[] aOpenAnime_; // 0x10
	private bool bSelectLock_; // 0x3C
	private static bool bSelectLockGlobal_; // 0x18

	// Nested types
	public enum MenuFrameId // TypeDefIndex: 6429
	{
		Talk = 0,
		Facility = 1,
		Diagnosis = 2
	}

	public enum Place // TypeDefIndex: 6430
	{
		LeftSide = 0,
		RightSide = 1,
		RightSideUp = 2,
		Center = 3
	}

	// Constructors
	public UIAskMenu() {} // 0x007E1E80-0x007E1E90
	static UIAskMenu() {} // 0x007E1E90-0x007E23A0

	// Methods
	public void EnableSelectLock(bool bEnable) {} // 0x007E19C0-0x007E19D0
	public static void EnableSelectLockGlobal(bool bEnable) {} // 0x007E19D0-0x007E1A40
	public static bool IsEnableSelectLockGlobal() => default; // 0x007E1A40-0x007E1AB0
	public static UIAskMenu Create(MenuFrameId frameId = MenuFrameId.Talk /* Metadata: 0x00612D40 */) => default; // 0x007D9700-0x007D98E0
	// [IteratorStateMachine] // 0x006267D0-0x00626840
	public virtual IEnumerator MainFlow(string sOpenAnime, Action<int> resultCb) => default; // 0x007E1AB0-0x007E1B30
	// [IteratorStateMachine] // 0x00626840-0x006268B0
	public virtual IEnumerator MainFlow(Item[] itemTable, int defaultIndex, bool bRightSide, Action<int> resultCb) => default; // 0x007E1B60-0x007E1C00
	// [IteratorStateMachine] // 0x006268B0-0x00626920
	public virtual IEnumerator MainFlow(Item[] itemTable, int defaultIndex, bool bRightSide) => default; // 0x007E1C30-0x007E1CC0
	// [IteratorStateMachine] // 0x00626920-0x00626990
	public virtual IEnumerator MainFlow(Item[] itemTable, int defaultIndex, Place place, Action<int> resultCb) => default; // 0x007E1CF0-0x007E1D90
	// [IteratorStateMachine] // 0x00626990-0x00626A00
	public virtual IEnumerator MainFlow(Item[] itemTable, int defaultIndex, Place place) => default; // 0x007E1DC0-0x007E1E50
}

