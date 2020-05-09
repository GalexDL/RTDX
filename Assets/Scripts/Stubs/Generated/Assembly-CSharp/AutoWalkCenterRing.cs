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

public class AutoWalkCenterRing : MonoBehaviour // TypeDefIndex: 5774
{
	// Fields
	private int m_status; // 0x18
	private int m_next; // 0x1C
	private int m_oldFollowId; // 0x20
	private bool m_bVisible; // 0x24
	private bool m_bVisibleDirty; // 0x25
	private bool m_bVisibleForDungeonCamera; // 0x26
	private bool m_bMainLoopCoroutine; // 0x27
	private GameObject m_prefabAutoRingCrash; // 0x28
	private GameObject m_prefabAutoRingCrashObj; // 0x30

	// Constructors
	public AutoWalkCenterRing() {} // 0x0086BC90-0x0086BCB0

	// Methods
	private void Start() {} // 0x0086B3B0-0x0086B450
	private void DestroyCrashRing() {} // 0x0086B450-0x0086B510
	private void OnDestroy() {} // 0x0086B510-0x0086B540
	public void SetVisible(bool bEnable) {} // 0x0086B540-0x0086B570
	public void SetVisibleForDungeonCamera(bool bEnable) {} // 0x0086B570-0x0086B5A0
	private void CheckChangeAutoButton() {} // 0x0086B5A0-0x0086B660
	private void OnEnable() {} // 0x0086B660-0x0086B6F0
	private void OnDisable() {} // 0x0086B760-0x0086B7E0
	// [IteratorStateMachine] // 0x00621CA0-0x00621D10
	private IEnumerator MainLoop() => default; // 0x0086B6F0-0x0086B760
	private void Update() {} // 0x0086B810-0x0086BAA0
	private void LateUpdate() {} // 0x0086BAA0-0x0086BC90
}

