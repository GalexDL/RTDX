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
	public struct Arm : IEquatable<nn.irsensor.Arm> // TypeDefIndex: 8982
	{
		// Fields
		public bool isValid; // 0x10
		public Float2 wristPosition; // 0x14
		public Float2 armDirection; // 0x1C
		public int protrusionIndex; // 0x24
	
		// Methods
		public override string ToString() => default; // 0x01145F80-0x01145F90
		public static bool operator ==(Arm lhs, Arm rhs) => default; // 0x01145F90-0x01146040
		public static bool operator !=(Arm lhs, Arm rhs) => default; // 0x01146040-0x011461D0
		public override bool Equals(object right) => default; // 0x011461D0-0x011461E0
		public bool Equals(Arm other) => default; // 0x011461E0-0x01146280
		public override int GetHashCode() => default; // 0x01146280-0x01146530
	}
}
