/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn
{
	public struct Result : IEquatable<nn.Result> // TypeDefIndex: 8935
	{
		// Fields
		public const int ModuleBitsOffset = 0; // Metadata: 0x00630E03
		public const int ModuleBitsCount = 9; // Metadata: 0x00630E07
		public const int ModuleBitsMask = 511; // Metadata: 0x00630E0B
		public const int DescriptionBitsOffset = 9; // Metadata: 0x00630E0F
		public const int DescriptionBitsCount = 13; // Metadata: 0x00630E13
		public const int DescriptionBitsMask = 8191; // Metadata: 0x00630E17
		public uint innerValue; // 0x10
	
		// Constructors
		public Result(int module, int description) {
			innerValue = default;
		} // 0x00A0F590-0x00A0F5B0
	
		// Methods
		public bool IsSuccess() => default; // 0x00A0F5B0-0x00A0F6D0
		public void abortUnlessSuccess() {} // 0x00A0F6D0-0x00A0F710
		public int GetModule() => default; // 0x00A0F710-0x00A0F720
		public int GetDescription() => default; // 0x00A0F720-0x00A0F730
		public override string ToString() => default; // 0x00A0F730-0x00A0F740
		public override bool Equals(object obj) => default; // 0x00A0F740-0x00A0F7F0
		public bool Equals(Result other) => default; // 0x00A0F800-0x00A0F810
		public override int GetHashCode() => default; // 0x00A0F810-0x00A0F880
		public static bool operator ==(Result lhs, Result rhs) => default; // 0x00A0F7F0-0x00A0F800
		public static bool operator !=(Result lhs, Result rhs) => default; // 0x00A0F880-0x00A0F890
	}
}
