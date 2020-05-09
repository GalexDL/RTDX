/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode] // 0x0060D810-0x0060D890
	// [RequireComponent] // 0x0060D810-0x0060D890
	public class DdpBloom : PostEffectsBase // TypeDefIndex: 9521
	{
		// Fields
		public float sepBlurSpread; // 0x1C
		public float bloomIntensity; // 0x20
		public float bloomThreshold; // 0x24
		public float bloomAddBloom; // 0x28
		public int bloomBlurIterations; // 0x2C
		public Shader screenBlendShader; // 0x30
		private Material screenBlend; // 0x38
		public Shader brightPassFilterShader; // 0x40
		private Material brightPassFilterMaterial; // 0x48
		public Shader blurAndFlaresShader; // 0x50
		private Material blurAndFlaresMaterial; // 0x58
		private CommandBuffer commandBuf; // 0x60
		private CommandBuffer commandBuf2; // 0x68
		private RenderTexture tempTexture; // 0x70
		private bool bForceFromOutsideOneTime; // 0x78
	
		// Constructors
		public DdpBloom() {} // 0x00B44030-0x00B44060
	
		// Methods
		public void EnableForceFromOutsideOneTime() {} // 0x00B43790-0x00B437A0
		public override bool CheckResources() => default; // 0x00B437A0-0x00B438A0
		private void OnDisable() {} // 0x00B438A0-0x00B438B0
		private new void OnEnable() {} // 0x00B43980-0x00B439C0
		private void releaseCommandBuffer() {} // 0x00B438B0-0x00B43980
		private void createCommandBuffer() {} // 0x00B439C0-0x00B43D20
		public void RenderImageFromOutside(RenderTexture source, RenderTexture destination) {} // 0x00B43D20-0x00B43D30
		private void RenderImageCore(RenderTexture source, RenderTexture destination) {} // 0x00B43D30-0x00B44030
	}
}
