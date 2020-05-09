/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[ExecuteInEditMode] // 0x0060A1F0-0x0060A270
// [RequireComponent] // 0x0060A1F0-0x0060A270
public class PegasusMotionBlur : MonoBehaviour // TypeDefIndex: 6051
{
	// Fields
	[NonSerialized]
	public bool blurEnable; // 0x18
	[NonSerialized]
	public bool lastBlurEnable; // 0x19
	[NonSerialized]
	// [Range] // 0x006169A0-0x006169C0
	public float blurAmount; // 0x1C
	[NonSerialized]
	// [Range] // 0x006169C0-0x006169E0
	public float blurRateScale; // 0x20
	[NonSerialized]
	// [Range] // 0x006169E0-0x00616A00
	public float blurRateRotate; // 0x24
	[NonSerialized]
	// [Range] // 0x00616A00-0x00616A20
	public float blurRateCenterAlpha; // 0x28
	[NonSerialized]
	public bool extraBlurFlag; // 0x2C
	[NonSerialized]
	public bool twoLoopFlag; // 0x2D
	private Material material_; // 0x30
	private RenderTexture accumTexture_; // 0x38
	private CommandBuffer m_commandBuf; // 0x40
	private bool bEnableCommandBuffer_; // 0x48
	private Texture2D screenshotTexture_; // 0x50

	// Properties
	public RenderTexture AccumTexture { get => default; } // 0x00B6B200-0x00B6B210 
	public bool IsValid { get => default; } // 0x00B6B210-0x00B6B260 

	// Constructors
	public PegasusMotionBlur() {} // 0x00B6C420-0x00B6C450

	// Methods
	public void SetEnableCommandBuffer() {} // 0x00B6B090-0x00B6B0A0
	public void Reset() {} // 0x00B6B260-0x00B6B270
	private void OnEnable() {} // 0x00B6B270-0x00B6B300
	private void OnDisable() {} // 0x00B6B300-0x00B6B4A0
	private void Update() {} // 0x00B6B540-0x00B6B550
	private void ReleaseCommandBuffer() {} // 0x00B6B4A0-0x00B6B540
	public void CreateCommandBuffer() {} // 0x00B6B0A0-0x00B6B200
	private void MakeCommandBuffer(bool bFirstTrig) {} // 0x00B6B550-0x00B6BA40
	private void OnPreRender() {} // 0x00B6BA40-0x00B6BA50
	public Vector2 Vector2Rotate(Vector2 v, float degrees) => default; // 0x00B6BA50-0x00B6BB10
	private void OnPostRender() {} // 0x00B6BB10-0x00B6C0C0
	private bool OnRenderImageCore_(Texture source, RenderTexture destination) => default; // 0x00B6C0C0-0x00B6C420
}

