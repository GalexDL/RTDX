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
	public class WindowFont // TypeDefIndex: 8333
	{
		// Fields
		private Dictionary<ushort, KanjiElement> kanjiDict_; // 0x10
		private Texture2D fontTexture_; // 0x18
	
		// Nested types
		private enum ImageType // TypeDefIndex: 8334
		{
			IMAGE_TYPE_RGB = 0,
			IMAGE_TYPE_RGBA = 1,
			IMAGE_TYPE_NATIVE_RGB = 2,
			IMAGE_TYPE_NATIVE_RGBA = 3,
			IMAGE_TYPE_ETC_RGB = 4,
			IMAGE_TYPE_ETC_RGBA = 5,
			IMAGE_TYPE_NATIVE_RGB565 = 6,
			IMAGE_TYPE_LUMINOUSE44 = 7,
			IMAGE_TYPE_NATIVE_LUMINOUSE44 = 8,
			IMAGE_TYPE_NATIVE_RGBA4444 = 9,
			IMAGE_TYPE_NATIVE_RGBA5551 = 10,
			IMAGE_TYPE_NATIVE_LUMINOUSE4 = 11,
			IMAGE_TYPE_NATIVE_LUMINOUSE8 = 12,
			IMAGE_TYPE_NATIVE_LUMINOUSE88 = 13,
			IMAGE_TYPE_MAX = 14
		}
	
		public class KanjiElement // TypeDefIndex: 8335
		{
			// Fields
			public ushort uCode; // 0x10
			public ushort s; // 0x12
			public ushort t; // 0x14
			public ushort w; // 0x16
			public ushort h; // 0x18
			public short siOffsetX; // 0x1A
			public short siOffsetY; // 0x1C
			public ushort uExtentW; // 0x1E
			public ushort uExtentH; // 0x20
	
			// Constructors
			public KanjiElement() {} // 0x01622460-0x01622470
		}
	
		// Constructors
		public WindowFont() {} // 0x01622470-0x016224E0
	
		// Methods
		public Texture2D GetFontTexture() => default; // 0x01621DC0-0x01621DD0
		public KanjiElement GetKajiElement(ushort code) => default; // 0x01621DD0-0x01621E50
		public void Load(string dicPath, string imgPath) {} // 0x01621E50-0x01622460
	}
}
