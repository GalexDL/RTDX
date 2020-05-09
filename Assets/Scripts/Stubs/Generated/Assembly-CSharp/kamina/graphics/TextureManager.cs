/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace kamina.graphics
{
	public class TextureManager : Singleton<kamina.graphics.TextureManager> // TypeDefIndex: 8415
	{
		// Fields
		private Dictionary<int, Parameter> dicTexture_; // 0x10
	
		// Nested types
		public class Parameter // TypeDefIndex: 8416
		{
			// Fields
			public int controlId; // 0x10
			public Texture2D image; // 0x18
	
			// Constructors
			public Parameter() {} // 0x00A0C700-0x00A0C710
		}
	
		// Constructors
		public TextureManager() {} // 0x00A0CA70-0x00A0CC60
	
		// Methods
		public void CreateNativeTexture(int nativeControlId, int w, int h, int pixelByte) {} // 0x00A0C550-0x00A0C700
		public void SetPixelNativeTexture(int nativeControlId, int x, int y, float r, float g, float b, float a) {} // 0x00A0C710-0x00A0C7F0
		public void Apply(int nativeControlId) {} // 0x00A0C860-0x00A0C8D0
		public void DestroyNativeTexture(int nativeControlId) {} // 0x00A0C8D0-0x00A0C980
		public bool IsExistNativeTexture(int nativeControlId) => default; // 0x00A0C980-0x00A0C9E0
		public Texture2D GetNativeTexture(int nativeControlId) => default; // 0x00A0C7F0-0x00A0C860
		public List<Parameter> GetTextureList() => default; // 0x00A0C9E0-0x00A0CA70
	}
}
