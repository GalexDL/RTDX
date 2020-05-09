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
	// [AddComponentMenu] // 0x006064D0-0x00606570
	[ExecuteInEditMode] // 0x006064D0-0x00606570
	// [RequireComponent] // 0x006064D0-0x00606570
	public class BloomAndFlares : PostEffectsBase // TypeDefIndex: 4264
	{
		// Fields
		public TweakMode34 tweakMode; // 0x1C
		public BloomScreenBlendMode screenBlendMode; // 0x20
		public HDRBloomMode hdr; // 0x24
		private bool doHdr; // 0x28
		public float sepBlurSpread; // 0x2C
		public float useSrcAlphaAsMask; // 0x30
		public float bloomIntensity; // 0x34
		public float bloomThreshold; // 0x38
		public int bloomBlurIterations; // 0x3C
		public bool lensflares; // 0x40
		public int hollywoodFlareBlurIterations; // 0x44
		public LensflareStyle34 lensflareMode; // 0x48
		public float hollyStretchWidth; // 0x4C
		public float lensflareIntensity; // 0x50
		public float lensflareThreshold; // 0x54
		public Color flareColorA; // 0x58
		public Color flareColorB; // 0x68
		public Color flareColorC; // 0x78
		public Color flareColorD; // 0x88
		public Texture2D lensFlareVignetteMask; // 0x98
		public Shader lensFlareShader; // 0xA0
		private Material lensFlareMaterial; // 0xA8
		public Shader vignetteShader; // 0xB0
		private Material vignetteMaterial; // 0xB8
		public Shader separableBlurShader; // 0xC0
		private Material separableBlurMaterial; // 0xC8
		public Shader addBrightStuffOneOneShader; // 0xD0
		private Material addBrightStuffBlendOneOneMaterial; // 0xD8
		public Shader screenBlendShader; // 0xE0
		private Material screenBlend; // 0xE8
		public Shader hollywoodFlaresShader; // 0xF0
		private Material hollywoodFlaresMaterial; // 0xF8
		public Shader brightPassFilterShader; // 0x100
		private Material brightPassFilterMaterial; // 0x108
	
		// Constructors
		public BloomAndFlares() {} // 0x00355480-0x003555F0
	
		// Methods
		public override bool CheckResources() => default; // 0x00354340-0x00354480
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00354480-0x00354F70
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to) {} // 0x003553D0-0x00355480
		private void BlendFlares(RenderTexture from, RenderTexture to) {} // 0x003551F0-0x003553D0
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to) {} // 0x00354F70-0x00355090
		private void Vignette(float amount, RenderTexture from, RenderTexture to) {} // 0x00355090-0x003551F0
	}
}
