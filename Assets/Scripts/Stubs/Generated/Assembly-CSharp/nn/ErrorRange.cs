/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn
{
	public struct ErrorRange // TypeDefIndex: 8936
	{
		// Fields
		private int _module; // 0x10
		private int _descriptionBegin; // 0x14
		private int _descriptionEnd; // 0x18
	
		// Properties
		public int Module { get => default; } // 0x00A0F400-0x00A0F410 
		public int DescriptionBegin { get => default; } // 0x00A0F410-0x00A0F420 
		public int DescriptionEnd { get => default; } // 0x00A0F420-0x00A0F470 
	
		// Constructors
		internal ErrorRange(int Module, int DescriptionBegin, int DescriptionEnd) : this() {
			_module = default;
			_descriptionBegin = default;
			_descriptionEnd = default;
		} // 0x00A0F3F0-0x00A0F400
	
		// Methods
		public bool Includes(Result result) => default; // 0x00A0F470-0x00A0F4B0
	}
}
