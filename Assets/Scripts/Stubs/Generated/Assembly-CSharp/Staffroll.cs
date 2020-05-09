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

public class Staffroll : MonoBehaviour // TypeDefIndex: 5496
{
	// Fields
	public float SpaceTokenHeight; // 0x18
	public float RoleOffsetX; // 0x1C
	public float NmaeOffsetX; // 0x20
	public float StartFadeoutTime; // 0x24
	public float StartDispTime; // 0x28
	public float FadeTime; // 0x2C
	public float DispTime; // 0x30
	public StaffrollData StaffrollDataRef; // 0x38
	private Action forceExitCb_; // 0x40
	private bool bStopRequest_; // 0x48

	// Constructors
	public Staffroll() {} // 0x00910A70-0x00910AA0

	// Methods
	public static GameObject LoadAndInstantiatePrefab() => default; // 0x009108C0-0x00910980
	// [IteratorStateMachine] // 0x00620400-0x00620470
	public IEnumerator MainFlow(Action endCb, int startIndex = -1 /* Metadata: 0x00611A52 */) => default; // 0x00910980-0x00910A00
	public void StopRequest() {} // 0x00910A30-0x00910A40
	public void ForceStop() {} // 0x00910A40-0x00910A70
}

