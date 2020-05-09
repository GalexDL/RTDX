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
	// [AddComponentMenu] // 0x006071E0-0x00607280
	[ExecuteInEditMode] // 0x006071E0-0x00607280
	// [RequireComponent] // 0x006071E0-0x00607280
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase // TypeDefIndex: 4303
	{
		// Fields
		// [Range] // 0x00607B90-0x00607BB0
		public float intensity; // 0x1C
		// [Range] // 0x00607BB0-0x00607BD0
		public float radius; // 0x20
		// [Range] // 0x00607BD0-0x00607BF0
		public int blurIterations; // 0x24
		// [Range] // 0x00607BF0-0x00607C10
		public float blurFilterDistance; // 0x28
		// [Range] // 0x00607C10-0x00607C30
		public int downsample; // 0x2C
		public Texture2D rand; // 0x30
		public Shader aoShader; // 0x38
		private Material aoMaterial; // 0x40
	
		// Constructors
		public ScreenSpaceAmbientObscurance() {} // 0x00365F50-0x00365F80
	
		// Methods
		public override bool CheckResources() => default; // 0x00365780-0x00365870
		private void OnDisable() {} // 0x00365870-0x00365930
		[ImageEffectOpaque] // 0x00607F60-0x00607F70
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00365930-0x00365F50
	}
}
