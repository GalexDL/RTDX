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
	public class RankingOrderParam // TypeDefIndex: 9477
	{
		// Fields
		[SerializeField] // 0x00618180-0x00618190
		private NexPlugin.Ranking.OrderCalculation ordercalc; // 0x10
		[SerializeField] // 0x00618190-0x006181A0
		private NexPlugin.Ranking.FilterGroupIndex groupindex; // 0x14
		[SerializeField] // 0x006181A0-0x006181B0
		private byte groupnum; // 0x18
		[SerializeField] // 0x006181B0-0x006181C0
		private NexPlugin.Ranking.TimeScope timescope; // 0x1C
		// [Range] // 0x006181C0-0x00618210
		[SerializeField] // 0x006181C0-0x00618210
		private byte length; // 0x20
	
		// Constructors
		public RankingOrderParam() {} // 0x00DBB6A0-0x00DBB6C0
	
		// Methods
		public NexPlugin.RankingOrderParam GetRankingOrderParam() => default; // 0x00DBB5E0-0x00DBB690
	}
}
