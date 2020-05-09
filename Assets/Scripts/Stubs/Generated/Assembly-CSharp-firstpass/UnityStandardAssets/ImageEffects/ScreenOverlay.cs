/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 45: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4233-4338

namespace UnityStandardAssets.ImageEffects
{
	// [AddComponentMenu] // 0x00607140-0x006071E0
	[ExecuteInEditMode] // 0x00607140-0x006071E0
	// [RequireComponent] // 0x00607140-0x006071E0
	public class ScreenOverlay : PostEffectsBase // TypeDefIndex: 4301
	{
		// Fields
		public OverlayBlendMode blendMode; // 0x1C
		public float intensity; // 0x20
		public Texture2D texture; // 0x28
		public Shader overlayShader; // 0x30
		private Material overlayMaterial; // 0x38
	
		// Nested types
		public enum OverlayBlendMode // TypeDefIndex: 4302
		{
			Additive = 0,
			ScreenBlend = 1,
			Multiply = 2,
			Overlay = 3,
			AlphaBlend = 4
		}
	
		// Constructors
		public ScreenOverlay() {} // 0x00365760-0x00365780
	
		// Methods
		public override bool CheckResources() => default; // 0x00365520-0x00365600
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00365600-0x00365760
	}
}
