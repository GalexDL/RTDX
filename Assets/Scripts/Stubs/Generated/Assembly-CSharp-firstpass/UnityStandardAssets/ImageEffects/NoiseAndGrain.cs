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
	// [AddComponentMenu] // 0x00606F00-0x00606FA0
	[ExecuteInEditMode] // 0x00606F00-0x00606FA0
	// [RequireComponent] // 0x00606F00-0x00606FA0
	public class NoiseAndGrain : PostEffectsBase // TypeDefIndex: 4296
	{
		// Fields
		public float intensityMultiplier; // 0x1C
		public float generalIntensity; // 0x20
		public float blackIntensity; // 0x24
		public float whiteIntensity; // 0x28
		public float midGrey; // 0x2C
		public bool dx11Grain; // 0x30
		public float softness; // 0x34
		public bool monochrome; // 0x38
		public Vector3 intensities; // 0x3C
		public Vector3 tiling; // 0x48
		public float monochromeTiling; // 0x54
		public FilterMode filterMode; // 0x58
		public Texture2D noiseTexture; // 0x60
		public Shader noiseShader; // 0x68
		private Material noiseMaterial; // 0x70
		public Shader dx11NoiseShader; // 0x78
		private Material dx11NoiseMaterial; // 0x80
		private static float TILE_AMOUNT; // 0x00
	
		// Constructors
		public NoiseAndGrain() {} // 0x00363460-0x00363530
		static NoiseAndGrain() {} // 0x00363530-0x00363590
	
		// Methods
		public override bool CheckResources() => default; // 0x00362710-0x00362810
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00362810-0x003630F0
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr) {} // 0x003630F0-0x00363460
	}
}
