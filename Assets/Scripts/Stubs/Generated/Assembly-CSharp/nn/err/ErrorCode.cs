/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.err
{
	public struct ErrorCode // TypeDefIndex: 9149
	{
		// Fields
		public uint category; // 0x10
		public uint number; // 0x14
	
		// Methods
		public override string ToString() => default; // 0x00A152C0-0x00A15360
		public bool IsValid() => default; // 0x00A15380-0x00A153A0
		private static extern bool IsValid(ErrorCode errorCode); // 0x00A15360-0x00A15380
		public static extern ErrorCode GetInvalidErrorCode(); // 0x00A12E50-0x00A12E60
	}
}
