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
	public static class CharacterMotionDatabase // TypeDefIndex: 8552
	{
		// Fields
		private static Dictionary<uint, CharacterMotionDataParameter> s_dicCharacterMotion; // 0x00
	
		// Constructors
		static CharacterMotionDatabase() {} // 0x00754310-0x00754390
	
		// Methods
		public static CharacterMotionDataParameter GetParameter(string symbol) => default; // 0x00753A10-0x00753B30
		public static CharacterMotionDataParameter GetParameter(uint gfsSymgol) => default; // 0x00753B30-0x00753BD0
		public static List<KeyValuePair<string, float>> GetMotionKeySpeedList(uint charaGfxSymbol) => default; // 0x00753BD0-0x00753E30
		public static void Load() {} // 0x00753E30-0x00754290
		public static void Destroy() {} // 0x00754290-0x00754310
	}
}
