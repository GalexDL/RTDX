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
	// [AddComponentMenu] // 0x00606C00-0x00606CA0
	[ExecuteInEditMode] // 0x00606C00-0x00606CA0
	// [RequireComponent] // 0x00606C00-0x00606CA0
	public class Fisheye : PostEffectsBase // TypeDefIndex: 4290
	{
		// Fields
		// [Range] // 0x00607890-0x006078B0
		public float strengthX; // 0x1C
		// [Range] // 0x006078B0-0x006078D0
		public float strengthY; // 0x20
		public Shader fishEyeShader; // 0x28
		private Material fisheyeMaterial; // 0x30
	
		// Constructors
		public Fisheye() {} // 0x003611C0-0x003611F0
	
		// Methods
		public override bool CheckResources() => default; // 0x00360F70-0x00361050
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x00361050-0x003611C0
	}
}
