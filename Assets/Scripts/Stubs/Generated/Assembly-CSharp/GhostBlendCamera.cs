/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GhostBlendCamera : MonoBehaviour, IOffscreenCamera // TypeDefIndex: 6005
{
	// Fields
	public Camera parentMainCamera; // 0x18
	private RenderTexture m_renderTexture; // 0x20
	private Camera m_camera; // 0x28

	// Properties
	public bool IsValid { get => default; } // 0x00729060-0x007290A0 

	// Constructors
	public GhostBlendCamera() {} // 0x00729340-0x00729350

	// Methods
	public Camera GetCamera() => default; // 0x007290A0-0x007290B0
	private void Start() {} // 0x007290B0-0x00729160
	private void OnTerminate() {} // 0x00729160-0x00729170
	public void Enable() {} // 0x00729170-0x00729180
	public void Disable() {} // 0x00729180-0x00729190
	public RenderTexture GetMainRenderTexture() => default; // 0x00729190-0x007291A0
	private void Update() {} // 0x007291A0-0x007291B0
	private void LateUpdate() {} // 0x007291B0-0x00729340
}

