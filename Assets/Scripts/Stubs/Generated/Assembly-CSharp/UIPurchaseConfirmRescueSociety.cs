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

public class UIPurchaseConfirmRescueSociety : UIManagerBase // TypeDefIndex: 7449
{
	// Fields
	private PurchaseDecisionWindow purchaseConfirmWindow_; // 0x20

	// Nested types
	private class PurchaseDecisionWindow : UIWindowBase // TypeDefIndex: 7450
	{
		// Constructors
		public PurchaseDecisionWindow() {} // 0x00B4F7E0-0x00B4F7F0

		// Methods
		public void UpdateWindow(UIRescueSociety.CampInfo info) {} // 0x00B4F840-0x00B4FA80
		// [IteratorStateMachine] // 0x0064F630-0x0064F6A0
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00B4FE10-0x00B4FE90
		// [IteratorStateMachine] // 0x0064F6A0-0x0064F710
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x00B4FEC0-0x00B4FF40
	}

	// Constructors
	public UIPurchaseConfirmRescueSociety() {} // 0x00B4FBC0-0x00B4FBD0

	// Methods
	public static UIPurchaseConfirmRescueSociety Create(GameObject rootObj) => default; // 0x00B4F600-0x00B4F760
	public void Construct() {} // 0x00B4F760-0x00B4F7E0
	public void Init(UIRescueSociety.CampInfo initCamp) {} // 0x00B4F7F0-0x00B4F840
	// [IteratorStateMachine] // 0x0062C130-0x0062C1A0
	public IEnumerator OpenCaution() => default; // 0x00B4FA80-0x00B4FAF0
	// [IteratorStateMachine] // 0x0062C1A0-0x0062C210
	public IEnumerator CloseCaution() => default; // 0x00B4FB20-0x00B4FB90
}

