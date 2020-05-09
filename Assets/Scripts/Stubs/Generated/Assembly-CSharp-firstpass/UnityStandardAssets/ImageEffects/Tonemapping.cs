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
	// [AddComponentMenu] // 0x006074A0-0x00607540
	[ExecuteInEditMode] // 0x006074A0-0x00607540
	// [RequireComponent] // 0x006074A0-0x00607540
	public class Tonemapping : PostEffectsBase // TypeDefIndex: 4313
	{
		// Fields
		public TonemapperType type; // 0x1C
		public AdaptiveTexSize adaptiveTextureSize; // 0x20
		public AnimationCurve remapCurve; // 0x28
		private Texture2D curveTex; // 0x30
		public float exposureAdjustment; // 0x38
		public float middleGrey; // 0x3C
		public float white; // 0x40
		public float adaptionSpeed; // 0x44
		public Shader tonemapper; // 0x48
		public bool validRenderTextureFormat; // 0x50
		private Material tonemapMaterial; // 0x58
		private RenderTexture rt; // 0x60
		private RenderTextureFormat rtFormat; // 0x68
	
		// Nested types
		public enum TonemapperType // TypeDefIndex: 4314
		{
			SimpleReinhard = 0,
			UserCurve = 1,
			Hable = 2,
			Photographic = 3,
			OptimizedHejiDawson = 4,
			AdaptiveReinhard = 5,
			AdaptiveReinhardAutoWhite = 6
		}
	
		public enum AdaptiveTexSize // TypeDefIndex: 4315
		{
			Square16 = 16,
			Square32 = 32,
			Square64 = 64,
			Square128 = 128,
			Square256 = 256,
			Square512 = 512,
			Square1024 = 1024
		}
	
		// Constructors
		public Tonemapping() {} // 0x00368760-0x003687B0
	
		// Methods
		public override bool CheckResources() => default; // 0x00367750-0x00367940
		public float UpdateCurve() => default; // 0x00367940-0x00367C30
		private void OnDisable() {} // 0x00367C30-0x00367DD0
		private bool CreateInternalRenderTexture() => default; // 0x00367DD0-0x00367ED0
		[ImageEffectTransformsToLDR] // 0x00607F80-0x00607F90
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00367ED0-0x00368760
	}
}
