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
	// [AddComponentMenu] // 0x00606930-0x00606980
	[ExecuteInEditMode] // 0x00606930-0x00606980
	public class ContrastStretch : MonoBehaviour // TypeDefIndex: 4278
	{
		// Fields
		// [Range] // 0x00607830-0x00607850
		public float adaptationSpeed; // 0x18
		// [Range] // 0x00607850-0x00607870
		public float limitMinimum; // 0x1C
		// [Range] // 0x00607870-0x00607890
		public float limitMaximum; // 0x20
		private RenderTexture[] adaptRenderTex; // 0x28
		private int curAdaptIndex; // 0x30
		public Shader shaderLum; // 0x38
		private Material m_materialLum; // 0x40
		public Shader shaderReduce; // 0x48
		private Material m_materialReduce; // 0x50
		public Shader shaderAdapt; // 0x58
		private Material m_materialAdapt; // 0x60
		public Shader shaderApply; // 0x68
		private Material m_materialApply; // 0x70
	
		// Properties
		protected Material materialLum { get => default; } // 0x0035B2F0-0x0035B3B0 
		protected Material materialReduce { get => default; } // 0x0035B3B0-0x0035B470 
		protected Material materialAdapt { get => default; } // 0x0035B470-0x0035B530 
		protected Material materialApply { get => default; } // 0x0035B530-0x0035B5F0 
	
		// Constructors
		public ContrastStretch() {} // 0x0035C080-0x0035C100
	
		// Methods
		private void Start() {} // 0x0035B5F0-0x0035B670
		private void OnEnable() {} // 0x0035B670-0x0035B910
		private void OnDisable() {} // 0x0035B910-0x0035BBF0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0035BBF0-0x0035BE40
		private void CalculateAdaptation(Texture curTexture) {} // 0x0035BE40-0x0035C080
	}
}
