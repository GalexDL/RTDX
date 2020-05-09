/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public struct TouchState : IEquatable<nn.hid.TouchState> // TypeDefIndex: 9071
	{
		// Fields
		public long deltaTimeNanoSeconds; // 0x10
		public TouchAttribute attributes; // 0x18
		public int fingerId; // 0x1C
		public int x; // 0x20
		public int y; // 0x24
		public int diameterX; // 0x28
		public int diameterY; // 0x2C
		public int rotationAngle; // 0x30
		private int _reserved; // 0x34
	
		// Methods
		public override string ToString() => default; // 0x01143960-0x01143970
		public static bool operator ==(TouchState lhs, TouchState rhs) => default; // 0x0112E9B0-0x0112EA70
		public static bool operator !=(TouchState lhs, TouchState rhs) => default; // 0x01143970-0x01143B20
		public override bool Equals(object right) => default; // 0x01143B20-0x01143C40
		public bool Equals(TouchState other) => default; // 0x01143C40-0x01143CD0
		public override int GetHashCode() => default; // 0x01143CD0-0x01143D50
	}
}
