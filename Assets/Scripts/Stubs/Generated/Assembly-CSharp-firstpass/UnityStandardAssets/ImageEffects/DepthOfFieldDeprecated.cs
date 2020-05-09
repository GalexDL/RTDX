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
	// [AddComponentMenu] // 0x00606AC0-0x00606B60
	[ExecuteInEditMode] // 0x00606AC0-0x00606B60
	// [RequireComponent] // 0x00606AC0-0x00606B60
	public class DepthOfFieldDeprecated : PostEffectsBase // TypeDefIndex: 4283
	{
		// Fields
		private static int SMOOTH_DOWNSAMPLE_PASS; // 0x00
		private static float BOKEH_EXTRA_BLUR; // 0x04
		public Dof34QualitySetting quality; // 0x1C
		public DofResolution resolution; // 0x20
		public bool simpleTweakMode; // 0x24
		public float focalPoint; // 0x28
		public float smoothness; // 0x2C
		public float focalZDistance; // 0x30
		public float focalZStartCurve; // 0x34
		public float focalZEndCurve; // 0x38
		private float focalStartCurve; // 0x3C
		private float focalEndCurve; // 0x40
		private float focalDistance01; // 0x44
		public Transform objectFocus; // 0x48
		public float focalSize; // 0x50
		public DofBlurriness bluriness; // 0x54
		public float maxBlurSpread; // 0x58
		public float foregroundBlurExtrude; // 0x5C
		public Shader dofBlurShader; // 0x60
		private Material dofBlurMaterial; // 0x68
		public Shader dofShader; // 0x70
		private Material dofMaterial; // 0x78
		public bool visualize; // 0x80
		public BokehDestination bokehDestination; // 0x84
		private float widthOverHeight; // 0x88
		private float oneOverBaseSize; // 0x8C
		public bool bokeh; // 0x90
		public bool bokehSupport; // 0x91
		public Shader bokehShader; // 0x98
		public Texture2D bokehTexture; // 0xA0
		public float bokehScale; // 0xA8
		public float bokehIntensity; // 0xAC
		public float bokehThresholdContrast; // 0xB0
		public float bokehThresholdLuminance; // 0xB4
		public int bokehDownsample; // 0xB8
		private Material bokehMaterial; // 0xC0
		private Camera _camera; // 0xC8
		private RenderTexture foregroundTexture; // 0xD0
		private RenderTexture mediumRezWorkTexture; // 0xD8
		private RenderTexture finalDefocus; // 0xE0
		private RenderTexture lowRezWorkTexture; // 0xE8
		private RenderTexture bokehSource; // 0xF0
		private RenderTexture bokehSource2; // 0xF8
	
		// Nested types
		public enum Dof34QualitySetting // TypeDefIndex: 4284
		{
			OnlyBackground = 1,
			BackgroundAndForeground = 2
		}
	
		public enum DofResolution // TypeDefIndex: 4285
		{
			High = 2,
			Medium = 3,
			Low = 4
		}
	
		public enum DofBlurriness // TypeDefIndex: 4286
		{
			Low = 1,
			High = 2,
			VeryHigh = 4
		}
	
		public enum BokehDestination // TypeDefIndex: 4287
		{
			Background = 1,
			Foreground = 2,
			BackgroundAndForeground = 3
		}
	
		// Constructors
		public DepthOfFieldDeprecated() {} // 0x00360A20-0x00360AD0
		static DepthOfFieldDeprecated() {} // 0x00360AD0-0x00360B40
	
		// Methods
		private void CreateMaterials() {} // 0x0035E540-0x0035E620
		public override bool CheckResources() => default; // 0x0035E620-0x0035E7A0
		private void OnDisable() {} // 0x0035E7A0-0x0035E810
		private new void OnEnable() {} // 0x0035EA20-0x0035EA90
		private float FocalDistance01(float worldDist) => default; // 0x0035EA90-0x0035EBD0
		private int GetDividerBasedOnQuality() => default; // 0x0035EBD0-0x0035EC00
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider) => default; // 0x0035EC00-0x0035EC30
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0035EC30-0x0035F550
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread) {} // 0x0035F9B0-0x0035FC40
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread) {} // 0x00360080-0x00360320
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp) {} // 0x00360540-0x00360760
		private void Downsample(RenderTexture from, RenderTexture to) {} // 0x0035F870-0x0035F9B0
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget) {} // 0x0035FC40-0x00360080
		private void ReleaseTextures() {} // 0x00360320-0x00360540
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider) {} // 0x0035F550-0x0035F870
	}
}
