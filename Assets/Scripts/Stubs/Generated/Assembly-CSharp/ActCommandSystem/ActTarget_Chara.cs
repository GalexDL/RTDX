/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActTarget] // 0x0060B270-0x0060B2C0
	public class ActTarget_Chara : ActTarget_BasicSRT // TypeDefIndex: 8735
	{
		// Fields
		private static List<string> HeroPatnerGroupNameCache_; // 0x00
		private static Dictionary<Index, HeroPatnerGroup> HeroParnterGroupTbl_; // 0x08
	
		// Properties
		public override ActObjBase actObj { get => default; } // 0x00AA4C50-0x00AA4C60 
		public ActObjCharactor actChara { get => default; } // 0x00A8F600-0x00A8F6F0 
		public string SymbolNameBody { get => default; } // 0x00A9C200-0x00A9C2D0 
		public string SymbolNameFilter { get => default; } // 0x00AA4C60-0x00AA4D50 
		public bool HasSpecialFilter { get => default; } // 0x00A9C1A0-0x00A9C200 
		public bool MatchSpecialFilter { get => default; } // 0x00A9C2D0-0x00A9C630 
	
		// Nested types
		private enum HeroPatnerGroup // TypeDefIndex: 8736
		{
			Size1 = 0,
			Size2 = 1,
			Size3 = 2,
			Size4 = 3
		}
	
		// Constructors
		public ActTarget_Chara() {} // 0x00AA4D50-0x00AA4DB0
		static ActTarget_Chara() {} // 0x00AA4DB0-0x00AA5310
	
		// Methods
		public override bool IsTargetEnable(ActDataPlayer.PlayContext context) => default; // 0x00AA4AC0-0x00AA4B40
		private bool IsHeroPartnerGroup_(HeroPatnerGroup group, Index index) => default; // 0x00AA4B40-0x00AA4C30
		public override ActObjSnapshotState LookupActSnapshotState(ActSnapshotContext snapshotContext) => default; // 0x00AA4C30-0x00AA4C50
	}
}
