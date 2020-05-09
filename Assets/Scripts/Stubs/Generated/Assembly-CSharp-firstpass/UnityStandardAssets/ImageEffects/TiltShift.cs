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
	// [AddComponentMenu] // 0x00607410-0x006074A0
	// [RequireComponent] // 0x00607410-0x006074A0
	internal class TiltShift : PostEffectsBase // TypeDefIndex: 4310
	{
		// Fields
		public TiltShiftMode mode; // 0x1C
		public TiltShiftQuality quality; // 0x20
		// [Range] // 0x00607CF0-0x00607D10
		public float blurArea; // 0x24
		// [Range] // 0x00607D10-0x00607D30
		public float maxBlurSize; // 0x28
		// [Range] // 0x00607D30-0x00607D50
		public int downsample; // 0x2C
		public Shader tiltShiftShader; // 0x30
		private Material tiltShiftMaterial; // 0x38
	
		// Nested types
		public enum TiltShiftMode // TypeDefIndex: 4311
		{
			TiltShiftMode = 0,
			IrisMode = 1
		}
	
		public enum TiltShiftQuality // TypeDefIndex: 4312
		{
			Preview = 0,
			Normal = 1,
			High = 2
		}
	
		// Constructors
		public TiltShift() {} // 0x00367720-0x00367750
	
		// Methods
		public override bool CheckResources() => default; // 0x003673B0-0x003674A0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x003674A0-0x00367720
	}
}
