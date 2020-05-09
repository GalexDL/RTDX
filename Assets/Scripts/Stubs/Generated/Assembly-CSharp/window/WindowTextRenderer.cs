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
	public class WindowTextRenderer // TypeDefIndex: 8340
	{
		// Fields
		public GameObject parentObj; // 0x10
		private static Vector2 LocalAxisX; // 0x00
		private static Vector2 LocalAxisY; // 0x08
		private Texture[] m_apTextureImage; // 0x18
		private SortedDictionary<UGuiObjKey_, WindowUGuiGraphic> uGuiObjTbl_; // 0x20
		private List<UGuiObjKey_> unuseKeys_; // 0x28
		private RectangleS32 m_clipRectangleBase; // 0x30
		private RectangleS32 m_clipRectangle; // 0x40
	
		// Nested types
		private class UGuiObjKey_ : IComparable // TypeDefIndex: 8341
		{
			// Fields
			public TextureId textureId; // 0x10
			public int priority; // 0x14
	
			// Constructors
			public UGuiObjKey_() {} // 0x01624BA0-0x01624BB0
	
			// Methods
			public int CompareTo(object obj) => default; // 0x01625610-0x016257E0
			public override bool Equals(object obj) => default; // 0x016257E0-0x01625950
			public override int GetHashCode() => default; // 0x01625950-0x01625990
		}
	
		// Constructors
		public WindowTextRenderer() {} // 0x016254B0-0x01625560
		static WindowTextRenderer() {} // 0x01625560-0x01625610
	
		// Methods
		private void transformUVVertex_(ref UIVertex vtx) {} // 0x01623BD0-0x01623CD0
		private void transformPrim_(ref WindowUGuiGraphic.RectPrim prim) {} // 0x01623CD0-0x01623D20
		public void AllClear() {} // 0x01623D20-0x01623EA0
		public void BeginDraw() {} // 0x01623EA0-0x01624010
		public void EndDraw() {} // 0x01624010-0x016242C0
		private WindowUGuiGraphic GetOrAddUGuiObject_(UGuiObjKey_ key) => default; // 0x016242C0-0x01624940
		public void DrawRect(TextureId texId, int x, int y, int s, int t, int w, int h, Color32 color, int nPriority, bool vf = false /* Metadata: 0x00614700 */, bool hf = false /* Metadata: 0x00614701 */) {} // 0x01624940-0x01624BA0
		public void DrawRectZoom(TextureId texId, int x, int y, int w, int h, int s, int t, int sw, int th, Color32 color, int nPriority, bool vf = false /* Metadata: 0x00614702 */, bool hf = false /* Metadata: 0x00614703 */, bool bBlendMul = false /* Metadata: 0x00614704 */) {} // 0x01624BB0-0x01624E10
		public void FillRect(int x, int y, int w, int h, Color32 color, int nPriority) {} // 0x01624E10-0x01624F50
		public void DrawRectSetDirectPriority(TextureId texId, int x, int y, int s, int t, int w, int h, Color32 color, int nPriority, bool vf = false /* Metadata: 0x00614705 */, bool hf = false /* Metadata: 0x00614706 */) {} // 0x01624F50-0x01624F70
		public void SetClipRectangle(RectangleS32 pRect) {} // 0x01624F70-0x01624F80
		public void ClearClipRectangle() {} // 0x01624F80-0x01624FD0
		public void SetTextureImage(Texture pTextureImage, TextureId id) {} // 0x01624FD0-0x01625060
		public Texture GetTextureImage(TextureId id) => default; // 0x01625060-0x016250B0
		public void RequestDrawChara(int x, int y, int w, int h, int s, int t, int sw, int th, Color color, TextureId texId, int nPriority) {} // 0x016250B0-0x016254B0
	}
}
