/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace graphics
{
	public class CharacterMotionDataParameter // TypeDefIndex: 8553
	{
		// Fields
		public const int MOTION_TYPE_ANIME = 254; // Metadata: 0x00615095
		public const int MOTION_TYPE_NULL = 255; // Metadata: 0x00615099
		public string motionSymbol; // 0x10
		public string partsKey; // 0x18
		public string motionKey; // 0x20
		public Dictionary<uint, Character> dicCharacter; // 0x28
		public int eEyeMotionType; // 0x30
		public int eMouthMotionType; // 0x34
	
		// Nested types
		private enum Type // TypeDefIndex: 8554
		{
			TYPE_PACK = 0,
			TYPE_ANIME = 1
		}
	
		public class Character // TypeDefIndex: 8555
		{
			// Fields
			public uint gfxSymbol; // 0x10
			public float speed; // 0x14
			public int eEyeMotionType; // 0x18
			public int eMouthMotionType; // 0x1C
	
			// Constructors
			public Character() {} // 0x00753A00-0x00753A10
		}
	
		// Constructors
		public CharacterMotionDataParameter() {} // 0x00753990-0x00753A00
	}
}
