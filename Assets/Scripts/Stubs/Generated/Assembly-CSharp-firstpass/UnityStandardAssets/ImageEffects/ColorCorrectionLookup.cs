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
	// [AddComponentMenu] // 0x006067F0-0x00606840
	[ExecuteInEditMode] // 0x006067F0-0x00606840
	public class ColorCorrectionLookup : PostEffectsBase // TypeDefIndex: 4275
	{
		// Fields
		public Shader shader; // 0x20
		private Material material; // 0x28
		public Texture3D converted3DLut; // 0x30
		public string basedOnTempTex; // 0x38
	
		// Constructors
		public ColorCorrectionLookup() {} // 0x0035AC70-0x0035ACE0
	
		// Methods
		public override bool CheckResources() => default; // 0x0035A160-0x0035A240
		private void OnDisable() {} // 0x0035A240-0x0035A300
		private void OnDestroy() {} // 0x0035A300-0x0035A3C0
		public void SetIdentityLut() {} // 0x0035A3C0-0x0035A5F0
		public bool ValidDimensions(Texture2D tex2d) => default; // 0x0035A5F0-0x0035A710
		public void Convert(Texture2D temp2DTex, string path) {} // 0x0035A710-0x0035AAA0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x0035AAA0-0x0035AC70
	}
}
