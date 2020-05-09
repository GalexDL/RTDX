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

public class DebugDialog : MonoBehaviour // TypeDefIndex: 4607
{
	// Fields
	public Animator m_animator; // 0x18
	private List<Kind> m_listButton; // 0x20
	private Dictionary<Kind, Button> m_dicButton; // 0x28
	private int m_select; // 0x30
	private int m_prev; // 0x34
	private bool m_bClose; // 0x38

	// Nested types
	public enum SetupPattern // TypeDefIndex: 4608
	{
		YesOnly = 0,
		Max = 1
	}

	public enum Kind // TypeDefIndex: 4609
	{
		YES = 0,
		NO = 1,
		MAX = 2,
		NONE = 2
	}

	public enum Result // TypeDefIndex: 4610
	{
		YES = 0,
		NO = 1,
		CANCEL = 2,
		MAX = 3,
		NONE = 3
	}

	public class Button // TypeDefIndex: 4611
	{
		// Fields
		public GameObject obj; // 0x10
		public string text; // 0x18
		public int textId; // 0x20
		public Result result; // 0x24

		// Constructors
		public Button() {} // 0x0098ECB0-0x0098ECC0
	}

	// Constructors
	public DebugDialog() {} // 0x0098F150-0x0098F1F0

	// Methods
	private void Start() {} // 0x0098EAF0-0x0098EB00
	private void Update() {} // 0x0098EB00-0x0098EB10
	public void Setup(SetupPattern pattern) {} // 0x0098EB10-0x0098EC00
	private void SetButton(Kind kind, string text, Result result) {} // 0x0098EC00-0x0098ECB0
	public void PlayOpen() {} // 0x0098ECC0-0x0098ED20
	public void PlayClose() {} // 0x0098ED20-0x0098ED80
	// [IteratorStateMachine] // 0x0061A540-0x0061A5B0
	public IEnumerator Select() => default; // 0x0098ED80-0x0098EDF0
	public Result GetResult() => default; // 0x0098EE20-0x0098EEB0
	// [IteratorStateMachine] // 0x0061A5B0-0x0061A620
	public IEnumerator WaitAnimation() => default; // 0x0098EEB0-0x0098EF20
	public bool IsClosed() => default; // 0x0098EF50-0x0098F000
	private void Close() {} // 0x0098F000-0x0098F070
	public void OnButtonRelease_YES() {} // 0x0098F070-0x0098F0E0
	public void OnButtonRelease_NO() {} // 0x0098F0E0-0x0098F150
}

