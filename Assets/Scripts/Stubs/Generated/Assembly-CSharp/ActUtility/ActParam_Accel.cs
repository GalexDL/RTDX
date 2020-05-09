/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActUtility
{
	[Serializable]
	public class ActParam_Accel // TypeDefIndex: 8678
	{
		// Fields
		public AccelType startType; // 0x10
		public AccelType endType; // 0x14
		public float startRatio; // 0x18
		public float endRatio; // 0x1C
	
		// Nested types
		public enum AccelType // TypeDefIndex: 8679
		{
			Custom = 0,
			Low = 100,
			High = 200,
			None = 999
		}
	
		// Constructors
		public ActParam_Accel() {} // 0x00859250-0x00859270
	
		// Methods
		public void setupMoveFloatByTime(ref MoveFloatVer2 dst, float startValue, float goalValue, float time) {} // 0x00858FB0-0x00859060
		public void setupMoveFloatByTime(ref MoveVector3 dst, Vector3 startValue, Vector3 goalValue, float time) {} // 0x00859060-0x00859140
		public void setupMoveFloatBySpeed(ref MoveFloatVer2 dst, float startValue, float goalValue, float speed) {} // 0x00859140-0x00859250
	}
}
