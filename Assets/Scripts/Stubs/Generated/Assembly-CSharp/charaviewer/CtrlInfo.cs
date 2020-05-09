/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class CtrlInfo // TypeDefIndex: 8462
	{
		// Fields
		private PointStep touchStep; // 0x10
		private Vector3 touchLastPos; // 0x14
		private Vector2 touchDrag; // 0x20
		private PointState[] pointStatus; // 0x28
	
		// Properties
		public Vector2 LeftDrag { get => default; } // 0x0074B0D0-0x0074B180 
		public Vector2 RightDrag { get => default; } // 0x0074B180-0x0074B1C0 
		public Vector2 CenterDrag { get => default; } // 0x0074B1C0-0x0074B200 
		public float WheelValue { get; private set; } // 0x0074B200-0x0074B210 0x0074B210-0x0074B220
	
		// Nested types
		private enum PointStep // TypeDefIndex: 8463
		{
			Wait = 0,
			Move = 1
		}
	
		private class PointState // TypeDefIndex: 8464
		{
			// Fields
			public PointStep step; // 0x10
			public Vector3 pos; // 0x14
			public Vector2 drag; // 0x20
			private int numButton; // 0x28
	
			// Constructors
			public PointState() {} // Dummy constructor
			public PointState(int button) {} // 0x0074BA00-0x0074BA90
	
			// Methods
			public Vector2 Update() => default; // 0x0074B550-0x0074B6F0
		}
	
		// Constructors
		public CtrlInfo() {} // 0x0074B6F0-0x0074BA00
	
		// Methods
		private Vector2 GetTouchDragValue() => default; // 0x0074B220-0x0074B490
		public void Update() {} // 0x0074B490-0x0074B550
	}
}
