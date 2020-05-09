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
	// [AddComponentMenu] // 0x00606660-0x00606700
	[ExecuteInEditMode] // 0x00606660-0x00606700
	// [RequireComponent] // 0x00606660-0x00606700
	public class BlurOptimized : PostEffectsBase // TypeDefIndex: 4269
	{
		// Fields
		// [Range] // 0x00607770-0x00607790
		public int downsample; // 0x1C
		// [Range] // 0x00607790-0x006077B0
		public float blurSize; // 0x20
		// [Range] // 0x006077B0-0x006077D0
		public int blurIterations; // 0x24
		public BlurType blurType; // 0x28
		public Shader blurShader; // 0x30
		private Material blurMaterial; // 0x38
	
		// Nested types
		public enum BlurType // TypeDefIndex: 4270
		{
			StandardGauss = 0,
			SgxGauss = 1
		}
	
		// Constructors
		public BlurOptimized() {} // 0x003568D0-0x00356900
	
		// Methods
		public override bool CheckResources() => default; // 0x003563A0-0x00356480
		public void OnDisable() {} // 0x00356480-0x00356540
		public void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00356540-0x003568D0
	}
}
