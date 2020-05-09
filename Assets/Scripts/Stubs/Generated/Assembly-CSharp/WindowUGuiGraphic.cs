/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [RequireComponent] // 0x0060A780-0x0060A810
// [RequireComponent] // 0x0060A780-0x0060A810
public class WindowUGuiGraphic : Graphic // TypeDefIndex: 8101
{
	// Fields
	private List<RectPrim> prims_; // 0x80
	public Texture texture; // 0x88

	// Properties
	public override Texture mainTexture { get => default; } // 0x007475E0-0x007475F0 

	// Nested types
	public class RectPrim // TypeDefIndex: 8102
	{
		// Fields
		public UIVertex p0; // 0x10
		public UIVertex p1; // 0x5C
		public UIVertex p2; // 0xA8
		public UIVertex p3; // 0xF4

		// Constructors
		public RectPrim() {} // 0x00747B50-0x00747B60
	}

	// Constructors
	public WindowUGuiGraphic() {} // 0x00747AC0-0x00747B50

	// Methods
	public void Begin() {} // 0x007475F0-0x00747640
	public void AddPrim(RectPrim prim) {} // 0x00747640-0x007476A0
	public void End() {} // 0x007476A0-0x007476B0
	protected override void OnPopulateMesh(VertexHelper vh) {} // 0x007476B0-0x00747AC0
}

