/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[Serializable]
	public class ActFuncSet // TypeDefIndex: 8700
	{
		// Fields
		[SerializeField] // 0x00617730-0x00617740
		public List<ActFuncData> funcs; // 0x10
		private static Regex match_FunctionBox; // 0x00
		private static Regex match_Function; // 0x08
		private static Regex match_EndBlock; // 0x10
		private static Regex match_Empty; // 0x18
		private static Regex match_Comment; // 0x20
	
		// Nested types
		private enum PaserMode_ // TypeDefIndex: 8701
		{
			Empty = 0,
			FunctionBox = 1,
			FunctionFirst = 2,
			Function = 3,
			FunctionBoxEnd = 4
		}
	
		// Constructors
		public ActFuncSet() {} // 0x00AA31E0-0x00AA3250
		static ActFuncSet() {} // 0x00AA3250-0x00AA3380
	
		// Methods
		public ActFuncData FindFunc(string name) => default; // 0x00AA20F0-0x00AA21B0
		public ActFuncData FindFunc(ActCommandCellList commandCellList) => default; // 0x00AA21C0-0x00AA2300
		public bool Deserialize_HumanText(string deserializeString_, out string errorMsg) {
			errorMsg = default;
			return default;
		} // 0x00AA2300-0x00AA2DD0
		public void Serialize_HumanText(StringBuilder sb, string startIndent) {} // 0x00AA2DD0-0x00AA31D0
	}
}
