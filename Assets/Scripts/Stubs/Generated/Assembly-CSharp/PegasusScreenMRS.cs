/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x006093A0-0x00609440
[ExecuteInEditMode] // 0x006093A0-0x00609440
// [RequireComponent] // 0x006093A0-0x00609440
public class PegasusScreenMRS : PostEffectsBase // TypeDefIndex: 4860
{
	// Fields
	public OverlayBlendMode blendMode; // 0x1C
	public float intensity; // 0x20
	public Texture2D BlendTex; // 0x28
	public Texture2D ScreenTex; // 0x30
	public Shader overlayShader; // 0x38
	private Material overlayMaterial; // 0x40
	private Vector4 vec; // 0x48
	private Vector3 pos; // 0x58
	private Vector2 posUV; // 0x64
	public float moveUV; // 0x6C
	private bool bIsChecked_; // 0x70

	// Nested types
	public enum OverlayBlendMode // TypeDefIndex: 4861
	{
		PegasusAdd = 0,
		PegasusBlend = 1
	}

	// Constructors
	public PegasusScreenMRS() {} // 0x00B6C8F0-0x00B6C910

	// Methods
	public override bool CheckResources() => default; // 0x00B6C450-0x00B6C4D0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00B6C4D0-0x00B6C650
	private void LateUpdate() {} // 0x00B6C650-0x00B6C8F0
}

