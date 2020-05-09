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
	// [AddComponentMenu] // 0x006067A0-0x006067F0
	[ExecuteInEditMode] // 0x006067A0-0x006067F0
	public class ColorCorrectionCurves : PostEffectsBase // TypeDefIndex: 4273
	{
		// Fields
		public AnimationCurve redChannel; // 0x20
		public AnimationCurve greenChannel; // 0x28
		public AnimationCurve blueChannel; // 0x30
		public bool useDepthCorrection; // 0x38
		public AnimationCurve zCurve; // 0x40
		public AnimationCurve depthRedChannel; // 0x48
		public AnimationCurve depthGreenChannel; // 0x50
		public AnimationCurve depthBlueChannel; // 0x58
		private Material ccMaterial; // 0x60
		private Material ccDepthMaterial; // 0x68
		private Material selectiveCcMaterial; // 0x70
		private Texture2D rgbChannelTex; // 0x78
		private Texture2D rgbDepthChannelTex; // 0x80
		private Texture2D zCurveTex; // 0x88
		public float saturation; // 0x90
		public bool selectiveCc; // 0x94
		public Color selectiveFromColor; // 0x98
		public Color selectiveToColor; // 0xA8
		public ColorCorrectionMode mode; // 0xB8
		public bool updateTextures; // 0xBC
		public Shader colorCorrectionCurvesShader; // 0xC0
		public Shader simpleColorCorrectionCurvesShader; // 0xC8
		public Shader colorCorrectionSelectiveShader; // 0xD0
		private bool updateTexturesOnStartup; // 0xD8
	
		// Nested types
		public enum ColorCorrectionMode // TypeDefIndex: 4274
		{
			Simple = 0,
			Advanced = 1
		}
	
		// Constructors
		public ColorCorrectionCurves() {} // 0x003598F0-0x0035A160
	
		// Methods
		private new void Start() {} // 0x00358EE0-0x00358F10
		private void Awake() {} // 0x00358F20-0x00358F30
		public override bool CheckResources() => default; // 0x00358F30-0x00359240
		public void UpdateParameters() {} // 0x00359240-0x00359600
		private void UpdateTextures() {} // 0x00359600-0x00359610
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00359610-0x003598F0
	}
}
