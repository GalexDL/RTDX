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

public class LoadingScreen : UIManagerBase // TypeDefIndex: 6256
{
	// Fields
	private GameObject mainObj_; // 0x20
	private LoadingType type_; // 0x28
	private LoadingWindow loadingWindow_; // 0x30
	private float loadingTime; // 0x38

	// Nested types
	public enum LoadingType // TypeDefIndex: 6257
	{
		Explain = 0,
		Normal = 1,
		Internet = 2
	}

	private class LoadingWindow : UIWindowBase // TypeDefIndex: 6258
	{
		// Constructors
		public LoadingWindow() {} // 0x00BFD5B0-0x00BFD5C0

		// Methods
		public override void Init(GameObject root) {} // 0x00BFDB30-0x00BFDB40
	}

	// Constructors
	public LoadingScreen() {} // 0x00BFD9A0-0x00BFD9B0

	// Methods
	public static LoadingScreen Create(LoadingType type) => default; // 0x00BFD260-0x00BFD5B0
	public void CountLoadingTime() {} // 0x00BFD5C0-0x00BFD600
	public void Open(Action cb = null) {} // 0x00BFD600-0x00BFD6D0
	public void Close(Action cb = null) {} // 0x00BFD6E0-0x00BFD7A0
	public void CloseWaitTime(Action cb = null) {} // 0x00BFD7B0-0x00BFD8E0
	// [IteratorStateMachine] // 0x00625580-0x006255F0
	private IEnumerator WaitTime(Action cb) => default; // 0x00BFD8F0-0x00BFD970
}

