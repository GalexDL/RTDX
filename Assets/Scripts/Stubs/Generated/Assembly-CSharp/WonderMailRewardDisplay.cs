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

public class WonderMailRewardDisplay : MonoBehaviour // TypeDefIndex: 5758
{
	// Fields
	private RewardTypes ask; // 0x18
	private RewardWindow rewardWindow; // 0x20

	// Nested types
	public enum RewardTypes // TypeDefIndex: 5759
	{
		ITEM = 0,
		QUEST = 1,
		MAX = 2
	}

	private class RewardWindow : UIWindowBase // TypeDefIndex: 5760
	{
		// Constructors
		public RewardWindow() {} // 0x00747D60-0x00747D70

		// Methods
		public override void Init(GameObject root) {} // 0x007481F0-0x00748200
		public void SetUpRewardWindow() {} // 0x00748050-0x00748160
	}

	// Constructors
	public WonderMailRewardDisplay() {} // 0x00747EB0-0x00747EC0

	// Methods
	public static WonderMailRewardDisplay Create() => default; // 0x00747B60-0x00747CC0
	public void Construct() {} // 0x00747CC0-0x00747D60
	// [IteratorStateMachine] // 0x00621AE0-0x00621B50
	public IEnumerator OpenWindow() => default; // 0x00747D70-0x00747DE0
	// [IteratorStateMachine] // 0x00621B50-0x00621BC0
	public IEnumerator CloseWindow() => default; // 0x00747E10-0x00747E80
}

