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
	// [AddComponentMenu] // 0x00606CA0-0x00606D40
	[ExecuteInEditMode] // 0x00606CA0-0x00606D40
	// [RequireComponent] // 0x00606CA0-0x00606D40
	internal class GlobalFog : PostEffectsBase // TypeDefIndex: 4291
	{
		// Fields
		// [Tooltip] // 0x006078D0-0x00607910
		public bool distanceFog; // 0x1B
		// [Tooltip] // 0x00607910-0x00607950
		public bool excludeFarPixels; // 0x1C
		// [Tooltip] // 0x00607950-0x00607990
		public bool useRadialDistance; // 0x1D
		// [Tooltip] // 0x00607990-0x006079D0
		public bool heightFog; // 0x1E
		// [Tooltip] // 0x006079D0-0x00607A10
		public float height; // 0x20
		// [Range] // 0x00607A10-0x00607A30
		public float heightDensity; // 0x24
		// [Tooltip] // 0x00607A30-0x00607A70
		public float startDistance; // 0x28
		public Shader fogShader; // 0x30
		private Material fogMaterial; // 0x38
	
		// Constructors
		public GlobalFog() {} // 0x00361CA0-0x00361CD0
	
		// Methods
		public override bool CheckResources() => default; // 0x003611F0-0x003612E0
		[ImageEffectOpaque] // 0x00607ED0-0x00607EE0
		private void OnRenderImage(RenderTexture source, RenderTexture destination) {} // 0x003612E0-0x00361B30
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr) {} // 0x00361B30-0x00361CA0
	}
}
