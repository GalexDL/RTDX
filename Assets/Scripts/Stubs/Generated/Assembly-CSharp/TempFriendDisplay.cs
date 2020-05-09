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

public class TempFriendDisplay : UIManagerBase // TypeDefIndex: 6383
{
	// Fields
	private TempFriendWindow statusWindow; // 0x20

	// Nested types
	private class TempFriendWindow : UIWindowBase // TypeDefIndex: 6384
	{
		// Constructors
		public TempFriendWindow() {} // 0x009201E0-0x009201F0

		// Methods
		public void Init(GameObject root, IPokemonStatus status) {} // 0x009205F0-0x009210A0
		// [IteratorStateMachine] // 0x00648C60-0x00648CD0
		public override IEnumerator OpenWindow(Action cb = null) => default; // 0x00921130-0x009211B0
		// [IteratorStateMachine] // 0x00648CD0-0x00648D40
		public override IEnumerator CloseWindow(Action cb = null) => default; // 0x009211E0-0x00921260
	}

	// Constructors
	public TempFriendDisplay() {} // 0x00920340-0x00920350

	// Methods
	public static TempFriendDisplay Create() => default; // 0x0091FFB0-0x00920160
	public void Construct() {} // 0x00920160-0x009201E0
	// [IteratorStateMachine] // 0x00626460-0x006264D0
	public IEnumerator Window_Open(IPokemonStatus status) => default; // 0x009201F0-0x00920270
	// [IteratorStateMachine] // 0x006264D0-0x00626540
	public IEnumerator Window_Close() => default; // 0x009202A0-0x00920310
}

