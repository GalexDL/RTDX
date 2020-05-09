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
	// [AddComponentMenu] // 0x00607370-0x00607410
	[ExecuteInEditMode] // 0x00607370-0x00607410
	// [RequireComponent] // 0x00607370-0x00607410
	public class SunShafts : PostEffectsBase // TypeDefIndex: 4307
	{
		// Fields
		public SunShaftsResolution resolution; // 0x1C
		public ShaftsScreenBlendMode screenBlendMode; // 0x20
		public Transform sunTransform; // 0x28
		public int radialBlurIterations; // 0x30
		public Color sunColor; // 0x34
		public Color sunThreshold; // 0x44
		public float sunShaftBlurRadius; // 0x54
		public float sunShaftIntensity; // 0x58
		public float maxRadius; // 0x5C
		public bool useDepthTexture; // 0x60
		public Shader sunShaftsShader; // 0x68
		private Material sunShaftsMaterial; // 0x70
		public Shader simpleClearShader; // 0x78
		private Material simpleClearMaterial; // 0x80
	
		// Nested types
		public enum SunShaftsResolution // TypeDefIndex: 4308
		{
			Low = 0,
			Normal = 1,
			High = 2
		}
	
		public enum ShaftsScreenBlendMode // TypeDefIndex: 4309
		{
			Screen = 0,
			Add = 1
		}
	
		// Constructors
		public SunShafts() {} // 0x003672F0-0x003673B0
	
		// Methods
		public override bool CheckResources() => default; // 0x00366A50-0x00366B40
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00366B40-0x003672F0
	}
}
