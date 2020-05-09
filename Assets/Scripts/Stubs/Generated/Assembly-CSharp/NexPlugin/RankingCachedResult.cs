/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public class RankingCachedResult : RankingResult // TypeDefIndex: 9358
	{
		// Fields
		internal uint maxLength; // 0x28
		internal NpDateTime createdTime; // 0x2C
		internal NpDateTime expiredTime; // 0x34
	
		// Nested types
		public enum LocalUpdateState // TypeDefIndex: 9359
		{
			UPDATE_SUCCESS = 0,
			UPDATE_FAILED = 1,
			UPDATE_ERROR = 2
		}
	
		// Constructors
		public RankingCachedResult() {} // 0x00FB1120-0x00FB1230
	
		// Methods
		public uint GetMaxLength() => default; // 0x00FC7AC0-0x00FC7AD0
		public NpDateTime GetCreatedTime() => default; // 0x00FC7AD0-0x00FC7AE0
		public NpDateTime GetExpiredTime() => default; // 0x00FC7AE0-0x00FC7AF0
		public LocalUpdateState LocalUpdate(RankingOrderParam orderParam, RankingScoreData scoreData, ulong pid, ulong nexUniqueId = 0 /* Metadata: 0x00631EA5 */, NpDateTime utcCurrentTime = default, List<byte> pCommonData = null) => default; // 0x00FC7AF0-0x00FC7C00
		public new void Trace() {} // 0x00FC7C00-0x00FC7C10
		public override string ToString() => default; // 0x00FC7C10-0x00FC7E30
	}
}
