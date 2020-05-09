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
	// [AddComponentMenu] // 0x00606570-0x00606610
	[ExecuteInEditMode] // 0x00606570-0x00606610
	// [RequireComponent] // 0x00606570-0x00606610
	public class BloomOptimized : PostEffectsBase // TypeDefIndex: 4265
	{
		// Fields
		// [Range] // 0x006076B0-0x006076D0
		public float threshold; // 0x1C
		// [Range] // 0x006076D0-0x006076F0
		public float intensity; // 0x20
		// [Range] // 0x006076F0-0x00607710
		public float blurSize; // 0x24
		private Resolution resolution; // 0x28
		// [Range] // 0x00607710-0x00607730
		public int blurIterations; // 0x2C
		public BlurType blurType; // 0x30
		public Shader fastBloomShader; // 0x38
		private Material fastBloomMaterial; // 0x40
	
		// Nested types
		public enum Resolution // TypeDefIndex: 4266
		{
			Low = 0,
			High = 1
		}
	
		public enum BlurType // TypeDefIndex: 4267
		{
			Standard = 0,
			Sgx = 1
		}
	
		// Constructors
		public BloomOptimized() {} // 0x00355B40-0x00355B70
	
		// Methods
		public override bool CheckResources() => default; // 0x003555F0-0x003556D0
		private void OnDisable() {} // 0x003556D0-0x00355790
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00355790-0x00355B40
	}
}
