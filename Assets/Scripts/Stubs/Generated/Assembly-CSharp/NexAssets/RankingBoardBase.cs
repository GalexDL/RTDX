/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	public abstract class RankingBoardBase : MonoBehaviour // TypeDefIndex: 9435
	{
		// Fields
		protected const int MENU_WIDTH = 320; // Metadata: 0x006320AA
		protected const int MENU_HEIGHT = 240; // Metadata: 0x006320AE
		protected const int COLUMN_SIZE = 48; // Metadata: 0x006320B2
		protected const float GUI_BASE_ALPHA = 1f; // Metadata: 0x006320B6
		private Image m_RankingPanel; // 0x18
		private Image m_RankingNoneDataPanel; // 0x20
		private Image m_HeaderScrollArea; // 0x28
		private Image m_HeaderScrollPanel; // 0x30
		private Image m_ScrollArea; // 0x38
		private Image m_ScrollPanel; // 0x40
		private Scrollbar m_VScrollbar; // 0x48
		private Scrollbar m_HScrollbar; // 0x50
		private GameObject[] m_HeaderObj; // 0x58
		private GameObject[] m_CellObj; // 0x60
		protected List<COLUMN_ARG> m_ColumnList; // 0x68
		public RankingBoardParam m_RankingBoardParam; // 0x70
	
		// Properties
		private Image RankingPanel { get; } // 0x00DBA950-0x00DBAA20 
		private Image RankingNoneDataPanel { get; } // 0x00DBAA20-0x00DBAAF0 
		private Image HeaderScrollArea { get; } // 0x00DBAAF0-0x00DBABC0 
		private Image HeaderScrollPanel { get; } // 0x00DBABC0-0x00DBAC90 
		private Image ScrollArea { get; } // 0x00DBAC90-0x00DBAD60 
		private Image ScrollPanel { get; } // 0x00DBAD60-0x00DBAE30 
		private Scrollbar VScrollbar { get; } // 0x00DBAE30-0x00DBAF00 
		private Scrollbar HScrollbar { get; } // 0x00DBAF00-0x00DBAFD0 
		private GameObject[] HeaderObj { get; } // 0x00DBAFD0-0x00DBB020 
		private GameObject[] CellObj { get; } // 0x00DBB020-0x00DBB070 
		public float VScroll { get; set; } // 0x00DBB070-0x00DBB0D0 0x00DBB0D0-0x00DBB180
		public float HScroll { get; set; } // 0x00DBB180-0x00DBB1E0 0x00DBB1E0-0x00DBB290
		protected abstract string HeaderTextTag { get; }
		protected abstract string ParamTextTag { get; }
	
		// Nested types
		public enum SIZE_TYPE // TypeDefIndex: 9436
		{
			PIXEL = 0,
			PERCENTAGE = 1
		}
	
		public enum POSITION_TYPE // TypeDefIndex: 9437
		{
			ALIGN = 0,
			INPUT = 1
		}
	
		public enum POSITION_ALIGN_V // TypeDefIndex: 9438
		{
			TOP = 0,
			CENTER = 1,
			BOTTOM = 2
		}
	
		public enum POSITION_ALIGN_H // TypeDefIndex: 9439
		{
			LEFT = 0,
			CENTER = 1,
			RIGHT = 2
		}
	
		[Serializable]
		public struct COLUMN_ARG // TypeDefIndex: 9440
		{
			// Fields
			public int indexType; // 0x10
			public int priority; // 0x14
			public int param; // 0x18
			public int size; // 0x1C
			public string title; // 0x20
			public bool disp; // 0x28
	
			// Constructors
			public COLUMN_ARG(int indexType_, string title_) {
				indexType = default;
				priority = default;
				param = default;
				size = default;
				title = default;
				disp = default;
			} // 0x00DBB5C0-0x00DBB5E0
		}
	
		[Serializable]
		public class RankingBoardParam // TypeDefIndex: 9441
		{
			// Fields
			public bool GuiFold; // 0x10
			public GUISkin GuiSkin; // 0x18
			public string ScoreboardTitle; // 0x20
			public int TitleHeight; // 0x28
			public SIZE_TYPE GuiSizeType; // 0x2C
			public POSITION_TYPE GuiPosType; // 0x30
			public POSITION_ALIGN_V GuiPosAlign_v; // 0x34
			public POSITION_ALIGN_H GuiPosAlign_h; // 0x38
			public int GuiPosMargin_v; // 0x3C
			public int GuiPosMargin_h; // 0x40
			public Vector2 RankingBoardPosition; // 0x44
			public Vector2 RankingBoardSize; // 0x4C
			public Vector2 RankingBoardPercentage; // 0x54
	
			// Constructors
			public RankingBoardParam() {} // 0x00DBB3E0-0x00DBB5C0
		}
	
		// Constructors
		protected RankingBoardBase() {} // 0x00DB9DD0-0x00DB9E60
	
		// Methods
		protected void Start() {} // 0x00DBB290-0x00DBB2C0
		public void SetRankingBoardEnable(bool enable) {} // 0x00DBB2C0-0x00DBB3E0
		protected abstract void CreateColumnIndex();
		protected abstract string GetContent(COLUMN_ARG columnArg);
		protected abstract int GetDataCount();
		protected void CreateColumn(COLUMN_ARG columnArg) {} // 0x00DB9750-0x00DB98B0
		protected void RankingBoard(bool enable = true /* Metadata: 0x006320A9 */) {} // 0x00DB8A60-0x00DB9600
	}
}
