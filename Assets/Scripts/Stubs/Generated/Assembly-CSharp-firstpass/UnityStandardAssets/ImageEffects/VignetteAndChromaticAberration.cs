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
	// [AddComponentMenu] // 0x00607590-0x00607630
	[ExecuteInEditMode] // 0x00607590-0x00607630
	// [RequireComponent] // 0x00607590-0x00607630
	public class VignetteAndChromaticAberration : PostEffectsBase // TypeDefIndex: 4318
	{
		// Fields
		public AberrationMode mode; // 0x1C
		public float intensity; // 0x20
		public float chromaticAberration; // 0x24
		public float axialAberration; // 0x28
		public float blur; // 0x2C
		public float blurSpread; // 0x30
		public float luminanceDependency; // 0x34
		public float blurDistance; // 0x38
		public Shader vignetteShader; // 0x40
		public Shader separableBlurShader; // 0x48
		public Shader chromAberrationShader; // 0x50
		private Material m_VignetteMaterial; // 0x58
		private Material m_SeparableBlurMaterial; // 0x60
		private Material m_ChromAberrationMaterial; // 0x68
	
		// Nested types
		public enum AberrationMode // TypeDefIndex: 4319
		{
			Simple = 0,
			Advanced = 1
		}
	
		// Constructors
		public VignetteAndChromaticAberration() {} // 0x00369C20-0x00369C70
	
		// Methods
		public override bool CheckResources() => default; // 0x003693E0-0x003694F0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x003694F0-0x00369C20
	}
}
