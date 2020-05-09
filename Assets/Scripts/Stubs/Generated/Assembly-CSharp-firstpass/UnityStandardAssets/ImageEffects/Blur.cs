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
	// [AddComponentMenu] // 0x00606610-0x00606660
	[ExecuteInEditMode] // 0x00606610-0x00606660
	public class Blur : MonoBehaviour // TypeDefIndex: 4268
	{
		// Fields
		// [Range] // 0x00607730-0x00607750
		public int iterations; // 0x18
		// [Range] // 0x00607750-0x00607770
		public float blurSpread; // 0x1C
		public Shader blurShader; // 0x20
		private static Material m_Material; // 0x00
	
		// Properties
		protected Material material { get => default; } // 0x00355B70-0x00355CA0 
	
		// Constructors
		public Blur() {} // 0x00356370-0x00356390
		static Blur() {} // 0x00356390-0x003563A0
	
		// Methods
		protected void OnDisable() {} // 0x00355CA0-0x00355DB0
		protected void Start() {} // 0x00355DB0-0x00355E80
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration) {} // 0x00355E80-0x00356050
		private void DownSample4x(RenderTexture source, RenderTexture dest) {} // 0x00356050-0x00356200
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00356200-0x00356370
	}
}
