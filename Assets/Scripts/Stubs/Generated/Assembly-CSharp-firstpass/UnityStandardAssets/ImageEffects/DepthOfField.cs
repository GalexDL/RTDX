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
	// [AddComponentMenu] // 0x00606A20-0x00606AC0
	[ExecuteInEditMode] // 0x00606A20-0x00606AC0
	// [RequireComponent] // 0x00606A20-0x00606AC0
	public class DepthOfField : PostEffectsBase // TypeDefIndex: 4280
	{
		// Fields
		public bool visualizeFocus; // 0x1B
		public float focalLength; // 0x1C
		public float focalSize; // 0x20
		public float aperture; // 0x24
		public Transform focalTransform; // 0x28
		public float maxBlurSize; // 0x30
		public bool highResolution; // 0x34
		public BlurType blurType; // 0x38
		public BlurSampleCount blurSampleCount; // 0x3C
		public bool nearBlur; // 0x40
		public float foregroundOverlap; // 0x44
		public Shader dofHdrShader; // 0x48
		private Material dofHdrMaterial; // 0x50
		public Shader dx11BokehShader; // 0x58
		private Material dx11bokehMaterial; // 0x60
		public float dx11BokehThreshold; // 0x68
		public float dx11SpawnHeuristic; // 0x6C
		public Texture2D dx11BokehTexture; // 0x70
		public float dx11BokehScale; // 0x78
		public float dx11BokehIntensity; // 0x7C
		private float focalDistance01; // 0x80
		private ComputeBuffer cbDrawArgs; // 0x88
		private ComputeBuffer cbPoints; // 0x90
		private float internalBlurWidth; // 0x98
		private Camera cachedCamera; // 0xA0
	
		// Nested types
		public enum BlurType // TypeDefIndex: 4281
		{
			DiscBlur = 0,
			DX11 = 1
		}
	
		public enum BlurSampleCount // TypeDefIndex: 4282
		{
			Low = 0,
			Medium = 1,
			High = 2
		}
	
		// Constructors
		public DepthOfField() {} // 0x0035E4D0-0x0035E540
	
		// Methods
		public override bool CheckResources() => default; // 0x0035C5E0-0x0035C6F0
		private new void OnEnable() {} // 0x0035C890-0x0035C900
		private void OnDisable() {} // 0x0035C900-0x0035CA50
		private void ReleaseComputeResources() {} // 0x0035CA50-0x0035CAA0
		private void CreateComputeResources() {} // 0x0035C6F0-0x0035C890
		private float FocalDistance01(float worldDist) => default; // 0x0035CAA0-0x0035CBE0
		private void WriteCoc(RenderTexture fromTo, bool fgDilate) {} // 0x0035CBE0-0x0035CEF0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0035CEF0-0x0035E4D0
	}
}
