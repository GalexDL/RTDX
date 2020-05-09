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
	// [AddComponentMenu] // 0x00606890-0x00606930
	[ExecuteInEditMode] // 0x00606890-0x00606930
	// [RequireComponent] // 0x00606890-0x00606930
	public class ContrastEnhance : PostEffectsBase // TypeDefIndex: 4277
	{
		// Fields
		// [Range] // 0x006077D0-0x006077F0
		public float intensity; // 0x1C
		// [Range] // 0x006077F0-0x00607810
		public float threshold; // 0x20
		private Material separableBlurMaterial; // 0x28
		private Material contrastCompositeMaterial; // 0x30
		// [Range] // 0x00607810-0x00607830
		public float blurSpread; // 0x38
		public Shader separableBlurShader; // 0x40
		public Shader contrastCompositeShader; // 0x48
	
		// Constructors
		public ContrastEnhance() {} // 0x0035B2C0-0x0035B2F0
	
		// Methods
		public override bool CheckResources() => default; // 0x0035AE70-0x0035AF70
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0035AF70-0x0035B2C0
	}
}
