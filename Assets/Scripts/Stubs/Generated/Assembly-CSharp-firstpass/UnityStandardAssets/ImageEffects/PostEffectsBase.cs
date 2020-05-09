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
	[ExecuteInEditMode] // 0x00607040-0x006070C0
	// [RequireComponent] // 0x00607040-0x006070C0
	public class PostEffectsBase : MonoBehaviour // TypeDefIndex: 4298
	{
		// Fields
		protected bool supportHDRTextures; // 0x18
		protected bool supportDX11; // 0x19
		protected bool isSupported; // 0x1A
	
		// Constructors
		public PostEffectsBase() {} // 0x003527F0-0x00352810
	
		// Methods
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create) => default; // 0x00352920-0x00352D40
		protected Material CreateMaterial(Shader s, Material m2Create) => default; // 0x00351F70-0x00352170
		private void OnEnable() {} // 0x00363DF0-0x00363E00
		protected bool CheckSupport() => default; // 0x00363E00-0x00363E10
		public virtual bool CheckResources() => default; // 0x00363E10-0x00363EC0
		protected void Start() {} // 0x00358F10-0x00358F20
		protected bool CheckSupport(bool needDepth) => default; // 0x00351E40-0x00351F70
		protected bool CheckSupport(bool needDepth, bool needHdr) => default; // 0x00357100-0x00357170
		public bool Dx11Support() => default; // 0x00363EC0-0x00363ED0
		protected void ReportAutoDisable() {} // 0x003521A0-0x00352240
		private bool CheckShader(Shader s) => default; // 0x00363ED0-0x003641A0
		protected void NotSupported() {} // 0x00352170-0x003521A0
		protected void DrawBorder(RenderTexture dest, Material material) {} // 0x003641A0-0x00364510
	}
}
