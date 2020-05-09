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
	// [AddComponentMenu] // 0x00607280-0x00607320
	[ExecuteInEditMode] // 0x00607280-0x00607320
	// [RequireComponent] // 0x00607280-0x00607320
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour // TypeDefIndex: 4304
	{
		// Fields
		// [Range] // 0x00607C30-0x00607C50
		public float m_Radius; // 0x18
		public SSAOSamples m_SampleCount; // 0x1C
		// [Range] // 0x00607C50-0x00607C70
		public float m_OcclusionIntensity; // 0x20
		// [Range] // 0x00607C70-0x00607C90
		public int m_Blur; // 0x24
		// [Range] // 0x00607C90-0x00607CB0
		public int m_Downsampling; // 0x28
		// [Range] // 0x00607CB0-0x00607CD0
		public float m_OcclusionAttenuation; // 0x2C
		// [Range] // 0x00607CD0-0x00607CF0
		public float m_MinZ; // 0x30
		public Shader m_SSAOShader; // 0x38
		private Material m_SSAOMaterial; // 0x40
		public Texture2D m_RandomTexture; // 0x48
		private bool m_Supported; // 0x50
	
		// Nested types
		public enum SSAOSamples // TypeDefIndex: 4305
		{
			Low = 0,
			Medium = 1,
			High = 2
		}
	
		// Constructors
		public ScreenSpaceAmbientOcclusion() {} // 0x00366970-0x003669B0
	
		// Methods
		private static Material CreateMaterial(Shader shader) => default; // 0x00365F80-0x00366030
		private static void DestroyMaterial(Material mat) {} // 0x00366030-0x003660E0
		private void OnDisable() {} // 0x003660E0-0x003660F0
		private void Start() {} // 0x003660F0-0x003661D0
		private void OnEnable() {} // 0x00366290-0x00366300
		private void CreateMaterials() {} // 0x003661D0-0x00366290
		[ImageEffectOpaque] // 0x00607F70-0x00607F80
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00366300-0x00366970
	}
}
