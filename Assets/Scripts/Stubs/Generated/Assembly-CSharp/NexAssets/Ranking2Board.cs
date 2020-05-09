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
	public class Ranking2Board : RankingBoardBase // TypeDefIndex: 9429
	{
		// Fields
		public bool m_ParamFold; // 0x78
		private Ranking2Info m_RankingInfo; // 0x80
		public GUIINDEX m_GuiIndex; // 0x88
		public COLUMN_ARG rankArg; // 0x90
		public COLUMN_ARG pidArg; // 0xB0
		public COLUMN_ARG uidArg; // 0xD0
		public COLUMN_ARG scoreArg; // 0xF0
		public COLUMN_ARG miscArg; // 0x110
		public COLUMN_ARG commonArg; // 0x130
	
		// Properties
		protected override string HeaderTextTag { get => default; } // 0x00DB98B0-0x00DB9900 
		protected override string ParamTextTag { get => default; } // 0x00DB9900-0x00DB9950 
	
		// Nested types
		public enum GUIINDEX // TypeDefIndex: 9430
		{
			PID = 1,
			UID = 2,
			RANK = 4,
			SCORE = 8,
			MISC = 16,
			COMMON = 32
		}
	
		private enum GUIINDEX_NUM // TypeDefIndex: 9431
		{
			RANK = 0,
			PID = 1,
			UID = 2,
			SCORE = 3,
			MISC = 4,
			COMMON = 5,
			MAX = 6
		}
	
		// Constructors
		public Ranking2Board() {} // 0x00DB9BE0-0x00DB9DD0
	
		// Methods
		public void ShowRankingBoard(Ranking2Info rankingInfo, bool enable = true /* Metadata: 0x00632027 */) {} // 0x00DB89E0-0x00DB8A60
		protected override void CreateColumnIndex() {} // 0x00DB9600-0x00DB9750
		protected override int GetDataCount() => default; // 0x00DB9950-0x00DB99B0
		protected override string GetContent(COLUMN_ARG columnArg) => default; // 0x00DB99B0-0x00DB9BE0
	}
}
