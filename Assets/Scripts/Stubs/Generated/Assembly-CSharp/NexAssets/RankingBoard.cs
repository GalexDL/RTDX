/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexPlugin;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	public class RankingBoard : RankingBoardBase // TypeDefIndex: 9432
	{
		// Fields
		public bool m_ParamFold; // 0x78
		private RankingResult m_RankingInfo; // 0x80
		public GUIINDEX m_GuiIndex; // 0x88
		public COLUMN_ARG orderArg; // 0x90
		public COLUMN_ARG pidArg; // 0xB0
		public COLUMN_ARG uidArg; // 0xD0
		public COLUMN_ARG categoryArg; // 0xF0
		public COLUMN_ARG scoreArg; // 0x110
		public COLUMN_ARG group0Arg; // 0x130
		public COLUMN_ARG group1Arg; // 0x150
		public COLUMN_ARG paramArg; // 0x170
		public COLUMN_ARG commonArg; // 0x190
	
		// Properties
		protected override string HeaderTextTag { get => default; } // 0x00DBA2E0-0x00DBA330 
		protected override string ParamTextTag { get => default; } // 0x00DBA330-0x00DBA380 
	
		// Nested types
		public enum GUIINDEX // TypeDefIndex: 9433
		{
			PID = 1,
			UID = 2,
			CATEGORY = 4,
			ORDER = 8,
			SCORE = 16,
			GROUP0 = 32,
			GROUP1 = 64,
			PARAM = 128,
			COMMON = 256
		}
	
		private enum GUIINDEX_NUM // TypeDefIndex: 9434
		{
			ORDER = 0,
			PID = 1,
			UID = 2,
			CATEGORY = 3,
			SCORE = 4,
			GROUP0 = 5,
			GROUP1 = 6,
			PARAM = 7,
			COMMON = 8,
			MAX = 9
		}
	
		// Constructors
		public RankingBoard() {} // 0x00DBA6D0-0x00DBA950
	
		// Methods
		public void ShowRankingBoard(RankingResult rankingInfo, bool enable = true /* Metadata: 0x0063205C */) {} // 0x00DBA090-0x00DBA110
		protected override void CreateColumnIndex() {} // 0x00DBA110-0x00DBA2E0
		protected override int GetDataCount() => default; // 0x00DBA380-0x00DBA3E0
		protected override string GetContent(COLUMN_ARG columnArg) => default; // 0x00DBA3E0-0x00DBA6D0
	}
}
