/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class NDHeroStatusDisplay : UIManagerBase // TypeDefIndex: 5170
{
	// Fields
	private HeroStatusWindow statusCaption; // 0x20

	// Nested types
	private class HeroStatusWindow : UIWindowBase // TypeDefIndex: 5171
	{
		// Fields
		private GameObject Tab; // 0x30
		private GameObject TabR; // 0x38
		private GameObject Cursor; // 0x40

		// Constructors
		public HeroStatusWindow() {} // 0x00E36BB0-0x00E36BC0

		// Methods
		public override void Init(GameObject root) {} // 0x00E37230-0x00E373E0
		public void UpdateFace(Index heroIndex, Index partnerIndex) {} // 0x00E36C90-0x00E36CD0
		public void UpdateTab(GameObject SetTab, Index pIndex) {} // 0x00E373E0-0x00E38360
		public void MoveCursor(Vector3 pos) {} // 0x00E36F90-0x00E37060
		// [IteratorStateMachine] // 0x00642C90-0x00642D00
		public IEnumerator OpenCursor(Action cb) => default; // 0x00E37120-0x00E371A0
		// [IteratorStateMachine] // 0x00642D00-0x00642D70
		public IEnumerator CloseCursor(Action cb) => default; // 0x00E36E50-0x00E36ED0
	}

	// Constructors
	public NDHeroStatusDisplay() {} // 0x00E37060-0x00E37070

	// Methods
	public static NDHeroStatusDisplay Create() => default; // 0x00E369B0-0x00E36B10
	public void Construct() {} // 0x00E36B10-0x00E36BB0
	public void OpenStatusWindow(Index heroIndex, Index partnerIndex) {} // 0x00E36BC0-0x00E36C90
	public void CloseStatusWindow() {} // 0x00E36CD0-0x00E36D70
	public void DecideCursor(Action cb = null) {} // 0x00E36D70-0x00E36E50
	// [IteratorStateMachine] // 0x0061E020-0x0061E090
	public IEnumerator AppearCursor_wait(Action cb = null) => default; // 0x00E36ED0-0x00E36F50
	public void MoveCursor(Vector3 pos) {} // 0x00E36F80-0x00E36F90
}

