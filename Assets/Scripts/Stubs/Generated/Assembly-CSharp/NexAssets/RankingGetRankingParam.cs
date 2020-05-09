/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NexPlugin;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexAssets
{
	[Serializable]
	public class RankingGetRankingParam // TypeDefIndex: 9476
	{
		// Fields
		[SerializeField] // 0x00618140-0x00618150
		private uint category; // 0x10
		[SerializeField] // 0x00618150-0x00618160
		private NexPlugin.Ranking.RankingMode mode; // 0x14
		[SerializeField] // 0x00618160-0x00618170
		private NexPlugin.Ranking.StatsFlag statsflag; // 0x18
		[SerializeField] // 0x00618170-0x00618180
		private RankingOrderParam rankingOrderParam; // 0x20
	
		// Constructors
		public RankingGetRankingParam() {} // 0x00DBB690-0x00DBB6A0
	
		// Methods
		public uint GetCategory() => default; // 0x00DB2CE0-0x00DB2CF0
		public NexPlugin.Ranking.RankingMode GetRankingMode() => default; // 0x00DB2CD0-0x00DB2CE0
		public NexPlugin.Ranking.StatsFlag GetStatsFlag() => default; // 0x00DB4ED0-0x00DB4F20
		public RankingOrderParam GetRankingOrderParam() => default; // 0x00DB2CF0-0x00DB2D00
	}
}
