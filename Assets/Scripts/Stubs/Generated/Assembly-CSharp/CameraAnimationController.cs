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

public class CameraAnimationController : MonoBehaviour // TypeDefIndex: 5952
{
	// Fields
	public Animation animationBody; // 0x18
	public Camera attachCamera; // 0x20
	public Transform attachCameraWolrdTransform; // 0x28
	public MainCamera mainCamera; // 0x30
	private Parameter parameter_; // 0x38
	private ResourceCache.Resource hResource_; // 0x40
	private bool bInit_; // 0x48

	// Nested types
	private class Parameter // TypeDefIndex: 5953
	{
		// Fields
		public string nowClipFileName; // 0x10
		public int nowNativeControlId; // 0x18
		public Vector3 vRotateEuler; // 0x1C
		public Vector3 vPrevWorldBasePosition; // 0x28
		public Quaternion vPrevWorldBaseRotate; // 0x34
		public Vector3 vPrevWorldBaseScale; // 0x44
		public Vector3 vPrevLocalPosition; // 0x50
		public Quaternion vPrevLocalRotate; // 0x5C
		public Vector3 vPrevLocalScale; // 0x6C
		public float fPrevNear; // 0x78
		public float fPrevFar; // 0x7C
		public float fPrevFOV; // 0x80

		// Constructors
		public Parameter() {} // 0x008C42F0-0x008C44A0

		// Methods
		public void Clear() {} // 0x008C3C50-0x008C3CB0
	}

	// Constructors
	public CameraAnimationController() {} // 0x008C4280-0x008C42F0

	// Methods
	// [IteratorStateMachine] // 0x00623970-0x006239E0
	private IEnumerator Start() => default; // 0x008C3910-0x008C3980
	private void LateUpdate() {} // 0x008C39B0-0x008C3C30
	public void PlayFromFileName(string fileName, int nativeControlId, Vector3 basePosition, Vector3 euler, WrapMode wrapMode) {} // 0x008C3CB0-0x008C4020
	public void Play(uint gfxSymbol, int nativeControlId, Vector3 basePosition, Vector3 euler, WrapMode wrapMode) {} // 0x008C4020-0x008C4110
	public void Stop() {} // 0x008C4110-0x008C4190
	public bool IsPlaying(string fileName) => default; // 0x008C3C30-0x008C3C50
	public bool IsPlaying() => default; // 0x008C4190-0x008C41B0
	public void CheckMainCameraAnimationOverwrite() {} // 0x008C41B0-0x008C4280
}

