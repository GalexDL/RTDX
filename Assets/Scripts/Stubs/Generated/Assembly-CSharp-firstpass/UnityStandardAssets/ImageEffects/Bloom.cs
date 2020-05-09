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
	// [AddComponentMenu] // 0x00606430-0x006064D0
	[ExecuteInEditMode] // 0x00606430-0x006064D0
	// [RequireComponent] // 0x00606430-0x006064D0
	public class Bloom : PostEffectsBase // TypeDefIndex: 4254
	{
		// Fields
		public TweakMode tweakMode; // 0x1C
		public BloomScreenBlendMode screenBlendMode; // 0x20
		public HDRBloomMode hdr; // 0x24
		private bool doHdr; // 0x28
		public float sepBlurSpread; // 0x2C
		public BloomQuality quality; // 0x30
		public float bloomIntensity; // 0x34
		public float bloomThreshold; // 0x38
		public Color bloomThresholdColor; // 0x3C
		public int bloomBlurIterations; // 0x4C
		public int hollywoodFlareBlurIterations; // 0x50
		public float flareRotation; // 0x54
		public LensFlareStyle lensflareMode; // 0x58
		public float hollyStretchWidth; // 0x5C
		public float lensflareIntensity; // 0x60
		public float lensflareThreshold; // 0x64
		public float lensFlareSaturation; // 0x68
		public Color flareColorA; // 0x6C
		public Color flareColorB; // 0x7C
		public Color flareColorC; // 0x8C
		public Color flareColorD; // 0x9C
		public Texture2D lensFlareVignetteMask; // 0xB0
		public Shader lensFlareShader; // 0xB8
		private Material lensFlareMaterial; // 0xC0
		public Shader screenBlendShader; // 0xC8
		private Material screenBlend; // 0xD0
		public Shader blurAndFlaresShader; // 0xD8
		private Material blurAndFlaresMaterial; // 0xE0
		public Shader brightPassFilterShader; // 0xE8
		private Material brightPassFilterMaterial; // 0xF0
	
		// Nested types
		public enum LensFlareStyle // TypeDefIndex: 4255
		{
			Ghosting = 0,
			Anamorphic = 1,
			Combined = 2
		}
	
		public enum TweakMode // TypeDefIndex: 4256
		{
			Basic = 0,
			Complex = 1
		}
	
		public enum HDRBloomMode // TypeDefIndex: 4257
		{
			Auto = 0,
			On = 1,
			Off = 2
		}
	
		public enum BloomScreenBlendMode // TypeDefIndex: 4258
		{
			Screen = 0,
			Add = 1
		}
	
		public enum BloomQuality // TypeDefIndex: 4259
		{
			Cheap = 0,
			High = 1
		}
	
		// Constructors
		public Bloom() {} // 0x003541C0-0x00354340
	
		// Methods
		public override bool CheckResources() => default; // 0x00352810-0x00352920
		public void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00352D40-0x00353B30
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to) {} // 0x00354100-0x003541C0
		private void BlendFlares(RenderTexture from, RenderTexture to) {} // 0x00353F10-0x00354100
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to) {} // 0x00353C10-0x00353D00
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to) {} // 0x00353B30-0x00353C10
		private void Vignette(float amount, RenderTexture from, RenderTexture to) {} // 0x00353D00-0x00353F10
	}
}
