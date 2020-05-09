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
	// [AddComponentMenu] // 0x00606390-0x00606430
	[ExecuteInEditMode] // 0x00606390-0x00606430
	// [RequireComponent] // 0x00606390-0x00606430
	public class Antialiasing : PostEffectsBase // TypeDefIndex: 4253
	{
		// Fields
		public AAMode mode; // 0x1C
		public bool showGeneratedNormals; // 0x20
		public float offsetScale; // 0x24
		public float blurRadius; // 0x28
		public float edgeThresholdMin; // 0x2C
		public float edgeThreshold; // 0x30
		public float edgeSharpness; // 0x34
		public bool dlaaSharp; // 0x38
		public Shader ssaaShader; // 0x40
		private Material ssaa; // 0x48
		public Shader dlaaShader; // 0x50
		private Material dlaa; // 0x58
		public Shader nfaaShader; // 0x60
		private Material nfaa; // 0x68
		public Shader shaderFXAAPreset2; // 0x70
		private Material materialFXAAPreset2; // 0x78
		public Shader shaderFXAAPreset3; // 0x80
		private Material materialFXAAPreset3; // 0x88
		public Shader shaderFXAAII; // 0x90
		private Material materialFXAAII; // 0x98
		public Shader shaderFXAAIII; // 0xA0
		private Material materialFXAAIII; // 0xA8
	
		// Constructors
		public Antialiasing() {} // 0x003527A0-0x003527F0
	
		// Methods
		public Material CurrentAAMaterial() => default; // 0x00351C60-0x00351CE0
		public override bool CheckResources() => default; // 0x00351CE0-0x00351E40
		public void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00352240-0x003527A0
	}
}
