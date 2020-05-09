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

public class AutoButton : MonoBehaviour // TypeDefIndex: 5769
{
	// Fields
	private const float ANIMATION_TIME = 0.25f; // Metadata: 0x00611EEB
	public Image m_image; // 0x18
	private GameObject m_autoButtonObject; // 0x20
	private Status m_status; // 0x28
	private Status m_changeNext; // 0x2C
	private float m_fAutoTime; // 0x30
	private int m_autoWalkCount; // 0x34
	private bool m_bMainLoopCoroutine; // 0x38
	private bool m_bVisible; // 0x39
	private bool m_bChangeRequest; // 0x3A
	private bool m_bChangeRequestExecuted; // 0x3B

	// Properties
	public Status NowStatus { get => default; } // 0x00866D00-0x00866D10 
	public bool ChangeRequest { get => default; } // 0x00866D10-0x00866D20 
	public bool ChangeRequestExecuted { get => default; } // 0x00866D20-0x00866D30 
	public Status NextStatus { get => default; } // 0x00866D30-0x00866D40 

	// Nested types
	public enum Status // TypeDefIndex: 5770
	{
		ManualWait = 0,
		AutoWait = 1
	}

	// Constructors
	public AutoButton() {} // 0x00867570-0x00867580

	// Methods
	// [IteratorStateMachine] // 0x00621BC0-0x00621C30
	private IEnumerator Start() => default; // 0x00866D40-0x00866DB0
	private void CheckChangeAutoButton() {} // 0x00866DE0-0x00867000
	private void SetVisible(bool bEnable) {} // 0x00867020-0x00867100
	public bool IsVisible() => default; // 0x00867100-0x00867110
	// [IteratorStateMachine] // 0x00621C30-0x00621CA0
	private IEnumerator MainLoop() => default; // 0x00867110-0x00867170
	private void OnEnable() {} // 0x008671A0-0x00867230
	private void OnDisable() {} // 0x00867230-0x008672B0
	public void RequestAutoMode() {} // 0x00867000-0x00867010
	public void RequestManualMode() {} // 0x00867010-0x00867020
	private void UpdateStatus(Status next) {} // 0x008672B0-0x00867420
	private void Update() {} // 0x00867420-0x00867550
	private void LateUpdate() {} // 0x00867550-0x00867560
	public void OnTouchButton() {} // 0x00867560-0x00867570
}

