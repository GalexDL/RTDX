/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace window
{
	[ExecuteInEditMode] // 0x0060AE90-0x0060AEA0
	public class WindowManager : SingletonMonoBehaviour<window.WindowManager> // TypeDefIndex: 8336
	{
		// Fields
		public Texture WhiteTexture; // 0x18
		public Texture[] WindowTextures; // 0x20
		private static FontPathData_[] s_apFontFileNameJp; // 0x00
		private static FontPathData_[] s_apFontFileNameForeign; // 0x08
		private static TextureId[] s_aFontWindowTextureId; // 0x10
		private Dictionary<FontType, WindowFont> fontTable_; // 0x28
	
		// Nested types
		private struct FontPathData_ // TypeDefIndex: 8337
		{
			// Fields
			public string pDic; // 0x10
			public string pImg; // 0x18
		}
	
		// Constructors
		public WindowManager() {} // 0x01622830-0x016228E0
		static WindowManager() {} // 0x016228E0-0x01622E90
	
		// Methods
		public WindowFont.KanjiElement GetKanjiElement(ushort code, FontType fontType) => default; // 0x016224E0-0x016225D0
		private void OnEnable() {} // 0x016225D0-0x01622820
		private void OnDisable() {} // 0x01622820-0x01622830
	}
}
