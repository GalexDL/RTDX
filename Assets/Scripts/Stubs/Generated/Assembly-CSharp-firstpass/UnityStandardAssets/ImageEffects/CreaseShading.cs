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
	// [AddComponentMenu] // 0x00606980-0x00606A20
	[ExecuteInEditMode] // 0x00606980-0x00606A20
	// [RequireComponent] // 0x00606980-0x00606A20
	public class CreaseShading : PostEffectsBase // TypeDefIndex: 4279
	{
		// Fields
		public float intensity; // 0x1C
		public int softness; // 0x20
		public float spread; // 0x24
		public Shader blurShader; // 0x28
		private Material blurMaterial; // 0x30
		public Shader depthFetchShader; // 0x38
		private Material depthFetchMaterial; // 0x40
		public Shader creaseApplyShader; // 0x48
		private Material creaseApplyMaterial; // 0x50
	
		// Constructors
		public CreaseShading() {} // 0x0035C5B0-0x0035C5E0
	
		// Methods
		public override bool CheckResources() => default; // 0x0035C100-0x0035C210
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0035C210-0x0035C5B0
	}
}
