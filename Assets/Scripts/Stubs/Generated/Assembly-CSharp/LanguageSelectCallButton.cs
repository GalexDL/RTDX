/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class LanguageSelectCallButton : MonoBehaviour // TypeDefIndex: 6088
{
	// Fields
	private const float ANIMATION_TIME = 0.05f; // Metadata: 0x0061252F
	public Image m_image; // 0x18
	public UIControlTMP m_text; // 0x20
	private bool m_bSelectDialog; // 0x28
	private bool m_bRequestSelectDialog; // 0x29
	private bool m_bMainLoopCoroutine; // 0x2A

	// Constructors
	public LanguageSelectCallButton() {} // 0x00901E40-0x00901E50

	// Methods
	private void Start() {} // 0x009019D0-0x00901A00
	// [IteratorStateMachine] // 0x006240B0-0x00624120
	private IEnumerator MainLoop() => default; // 0x00901B30-0x00901BA0
	private void OnEnable() {} // 0x00901BD0-0x00901C60
	private void OnDisable() {} // 0x00901C60-0x00901CE0
	public void Request() {} // 0x00901CE0-0x00901CF0
	// [IteratorStateMachine] // 0x00624120-0x00624190
	public IEnumerator Wait() => default; // 0x00901CF0-0x00901D60
	// [IteratorStateMachine] // 0x00624190-0x00624200
	private IEnumerator ExecuteDialog() => default; // 0x00901D90-0x00901E00
	private void UpdateName() {} // 0x00901A00-0x00901B30
	public void OnTouchButton() {} // 0x00901E30-0x00901E40
}

