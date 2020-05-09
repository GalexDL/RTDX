/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	public class ActDataSet // TypeDefIndex: 8687
	{
		// Fields
		public List<ActTargetCommandParallelData> seqList; // 0x10
		private static Regex match_Parallel; // 0x00
		private static Regex match_Target; // 0x08
		private static Regex match_TargetFlags; // 0x10
		private static Regex match_EndBlock; // 0x18
		private static Regex match_Empty; // 0x20
		private static Regex match_Comment; // 0x28
	
		// Nested types
		private enum PaserMode_ // TypeDefIndex: 8688
		{
			Empty = 0,
			ParallelFirst = 1,
			Parallel = 2,
			TargetCommandsFirst = 3,
			TargetCommands = 4
		}
	
		// Constructors
		public ActDataSet() {} // 0x00AA1030-0x00AA10A0
		static ActDataSet() {} // 0x00AA10A0-0x00AA1200
	
		// Methods
		public bool Deserialize_HumanText(string deserializeString_, out string errorMsg) {
			errorMsg = default;
			return default;
		} // 0x00A9E840-0x00A9F780
		public string Serialize_HumanText() => default; // 0x00A9F970-0x00AA0060
		public void RemoveCommand(ActCommandBase command) {} // 0x00AA01B0-0x00AA0500
		public void RemoveTargetCommands(ActTargetCommands tgtCmds) {} // 0x00AA0510-0x00AA06C0
		public ActTargetCommandParallelData FindTargetCommandParallelData(ActTargetCommands tgtCmd) => default; // 0x00AA06C0-0x00AA0820
		public ActTargetCommandParallelData FindTargetCommandParallelData(ActCommandCellList cellLst) => default; // 0x00AA0820-0x00AA0A00
		public ActTargetCommands FindTargetCommands(ActCommandCellList commandCellList) => default; // 0x00AA0A10-0x00AA0CD0
		public ActTargetCommands FindTargetCommands(ActCommandBase cmd) => default; // 0x00AA0CD0-0x00AA1020
		public void UpdateSnapshotContext(ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A977C0-0x00A97BB0
	}
}
