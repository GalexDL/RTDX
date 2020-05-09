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
	// [AddComponentMenu] // 0x00606E60-0x00606F00
	[ExecuteInEditMode] // 0x00606E60-0x00606F00
	// [RequireComponent] // 0x00606E60-0x00606F00
	public class MotionBlur : ImageEffectBase // TypeDefIndex: 4295
	{
		// Fields
		// [Range] // 0x00607A90-0x00607AB0
		public float blurAmount; // 0x28
		public bool extraBlur; // 0x2C
		private RenderTexture accumTexture; // 0x30
	
		// Constructors
		public MotionBlur() {} // 0x003626F0-0x00362710
	
		// Methods
		protected override void Start() {} // 0x003622D0-0x00362320
		protected override void OnDisable() {} // 0x00362320-0x003623A0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x003623A0-0x003626F0
	}
}
