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
	public class RankingScoreData // TypeDefIndex: 9478
	{
		// Fields
		[SerializeField] // 0x00618210-0x00618220
		private uint category; // 0x10
		[SerializeField] // 0x00618220-0x00618230
		private NexPlugin.Ranking.OrderBy orderby; // 0x14
		[SerializeField] // 0x00618230-0x00618240
		private NexPlugin.Ranking.UpdateMode mode; // 0x18
		// [Range] // 0x00618240-0x00618290
		[SerializeField] // 0x00618240-0x00618290
		private byte group0; // 0x1C
		// [Range] // 0x00618290-0x006182E0
		[SerializeField] // 0x00618290-0x006182E0
		private byte group1; // 0x1D
		[SerializeField] // 0x006182E0-0x006182F0
		private string param; // 0x20
		private ulong param_; // 0x28
	
		// Constructors
		public RankingScoreData() {} // 0x00DBB790-0x00DBB7F0
	
		// Methods
		public void Validate() {} // 0x00DBB6C0-0x00DBB790
		public NexPlugin.RankingScoreData GetRankingScoreData() => default; // 0x00DB3D40-0x00DB3E00
	}
}
