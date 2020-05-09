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
	// [AddComponentMenu] // 0x00606FA0-0x00607040
	[ExecuteInEditMode] // 0x00606FA0-0x00607040
	// [RequireComponent] // 0x00606FA0-0x00607040
	public class NoiseAndScratches : MonoBehaviour // TypeDefIndex: 4297
	{
		// Fields
		public bool monochrome; // 0x18
		private bool rgbFallback; // 0x19
		// [Range] // 0x00607AB0-0x00607AD0
		public float grainIntensityMin; // 0x1C
		// [Range] // 0x00607AD0-0x00607AF0
		public float grainIntensityMax; // 0x20
		// [Range] // 0x00607AF0-0x00607B10
		public float grainSize; // 0x24
		// [Range] // 0x00607B10-0x00607B30
		public float scratchIntensityMin; // 0x28
		// [Range] // 0x00607B30-0x00607B50
		public float scratchIntensityMax; // 0x2C
		// [Range] // 0x00607B50-0x00607B70
		public float scratchFPS; // 0x30
		// [Range] // 0x00607B70-0x00607B90
		public float scratchJitter; // 0x34
		public Texture grainTexture; // 0x38
		public Texture scratchTexture; // 0x40
		public Shader shaderRGB; // 0x48
		public Shader shaderYUV; // 0x50
		private Material m_MaterialRGB; // 0x58
		private Material m_MaterialYUV; // 0x60
		private float scratchTimeLeft; // 0x68
		private float scratchX; // 0x6C
		private float scratchY; // 0x70
	
		// Properties
		protected Material material { get => default; } // 0x003636D0-0x00363820 
	
		// Constructors
		public NoiseAndScratches() {} // 0x00363DA0-0x00363DF0
	
		// Methods
		protected void Start() {} // 0x00363590-0x003636D0
		protected void OnDisable() {} // 0x00363820-0x00363950
		private void SanitizeParameters() {} // 0x00363950-0x00363A80
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00363A80-0x00363DA0
	}
}
