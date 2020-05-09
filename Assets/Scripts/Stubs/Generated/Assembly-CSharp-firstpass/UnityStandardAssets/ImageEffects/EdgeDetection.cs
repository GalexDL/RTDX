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
	// [AddComponentMenu] // 0x00606B60-0x00606C00
	[ExecuteInEditMode] // 0x00606B60-0x00606C00
	// [RequireComponent] // 0x00606B60-0x00606C00
	public class EdgeDetection : PostEffectsBase // TypeDefIndex: 4288
	{
		// Fields
		public EdgeDetectMode mode; // 0x1C
		public float sensitivityDepth; // 0x20
		public float sensitivityNormals; // 0x24
		public float lumThreshold; // 0x28
		public float edgeExp; // 0x2C
		public float sampleDist; // 0x30
		public float edgesOnly; // 0x34
		public Color edgesOnlyBgColor; // 0x38
		public Shader edgeDetectShader; // 0x48
		private Material edgeDetectMaterial; // 0x50
		private EdgeDetectMode oldMode; // 0x58
	
		// Nested types
		public enum EdgeDetectMode // TypeDefIndex: 4289
		{
			TriangleDepthNormals = 0,
			RobertsCrossDepthNormals = 1,
			SobelDepth = 2,
			SobelDepthThin = 3,
			TriangleLuminance = 4
		}
	
		// Constructors
		public EdgeDetection() {} // 0x00360EF0-0x00360F70
	
		// Methods
		public override bool CheckResources() => default; // 0x00360B40-0x00360C40
		private new void Start() {} // 0x00360D00-0x00360D10
		private void SetCameraFlag() {} // 0x00360C40-0x00360D00
		private new void OnEnable() {} // 0x00360D10-0x00360D20
		[ImageEffectOpaque] // 0x00607EC0-0x00607ED0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00360D20-0x00360EF0
	}
}
