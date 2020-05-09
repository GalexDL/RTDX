/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [AddComponentMenu] // 0x00609440-0x006094E0
[ExecuteInEditMode] // 0x00609440-0x006094E0
// [RequireComponent] // 0x00609440-0x006094E0
public class PegasusScreenOverlay : PostEffectsBase // TypeDefIndex: 4862
{
	// Fields
	public OverlayBlendMode blendMode; // 0x1C
	public float intensity; // 0x20
	public Texture2D texture; // 0x28
	public Texture2D texture2; // 0x30
	public Shader overlayShader; // 0x38
	private Material overlayMaterial; // 0x40
	private bool bIsChecked_; // 0x48

	// Nested types
	public enum OverlayBlendMode // TypeDefIndex: 4863
	{
		Additive = 0,
		ScreenBlend = 1,
		Multiply = 2,
		Overlay = 3,
		AlphaBlend = 4,
		PegasusAdd = 5,
		PegasusBlend = 6
	}

	// Constructors
	public PegasusScreenOverlay() {} // 0x00B6CB10-0x00B6CB30

	// Methods
	public override bool CheckResources() => default; // 0x00B6C910-0x00B6C990
	private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00B6C990-0x00B6CB10
}

