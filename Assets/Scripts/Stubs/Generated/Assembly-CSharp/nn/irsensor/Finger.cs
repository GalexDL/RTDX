/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn.util;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.irsensor
{
	public struct Finger : IEquatable<nn.irsensor.Finger> // TypeDefIndex: 8980
	{
		// Fields
		public bool isValid; // 0x10
		public Float2 tip; // 0x14
		public float tipDepthFactor; // 0x1C
		public Float2 root; // 0x20
		public int protrusionIndex; // 0x28
	
		// Methods
		public override string ToString() => default; // 0x01149120-0x01149130
		public static bool operator ==(Finger lhs, Finger rhs) => default; // 0x01149130-0x01149200
		public static bool operator !=(Finger lhs, Finger rhs) => default; // 0x01149200-0x011493D0
		public override bool Equals(object right) => default; // 0x011493D0-0x011493E0
		public bool Equals(Finger other) => default; // 0x011493E0-0x011494A0
		public override int GetHashCode() => default; // 0x011494A0-0x01149520
	}
}
