/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[Serializable]
	public class ActCommandCellList : ISerializationCallbackReceiver // TypeDefIndex: 8696
	{
		// Fields
		public List<ActCommandCell> cellArray; // 0x10
		private static Regex match_Command_; // 0x00
	
		// Properties
		public ActCommandBase this[int colIdx] { get => default; set {} } // 0x008DC760-0x008DC780 0x008DC7A0-0x008DC7B0
		public int MaxColIdx { get => default; } // 0x008DA8C0-0x008DA950 
	
		// Constructors
		public ActCommandCellList() {} // 0x008DCE70-0x008DCEE0
		static ActCommandCellList() {} // 0x008DCEE0-0x008DCF60
	
		// Methods
		public void OnBeforeSerialize() {} // 0x008DBA20-0x008DBA30
		public void OnAfterDeserialize() {} // 0x008DBA30-0x008DBA40
		public void Deserialize_HumanText_Start() {} // 0x008DBC20-0x008DBC70
		public bool Deserialize_HumanText_Loop(string line, string lastComment) => default; // 0x008DBC70-0x008DBF50
		public void Deserialize_HumanText_Finish() {} // 0x008DBF50-0x008DC180
		public string Serialize_HumanText(StringBuilder sb, string startIndent) => default; // 0x008DC180-0x008DC6E0
		public List<ActCommandCell> GetEnumerator() => default; // 0x008DC6F0-0x008DC760
		public void SetCommand(int columnIdx, ActCommandBase command) {} // 0x008DC7B0-0x008DC950
		public ActCommandBase GetCommand(int columnIdx) => default; // 0x008DC780-0x008DC7A0
		public ActCommandCell GetCell(int columnIdx) => default; // 0x008DA390-0x008DA4D0
		public ActCommandCell FindCellCommand(ActCommandBase cmd) => default; // 0x008DCAA0-0x008DCBE0
		public void Clear(int columnIdx) {} // 0x008DC950-0x008DCAA0
		public void Remove(int columnIdx) {} // 0x008DCBE0-0x008DCD30
		public void InsertEmpty(int columnIdx) {} // 0x008DCD30-0x008DCE70
		public void RebuildOrderLink() {} // 0x008DBA40-0x008DBC20
	}
}
