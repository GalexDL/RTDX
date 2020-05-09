/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn.util;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public struct SixAxisSensorState // TypeDefIndex: 9067
	{
		// Fields
		public const float AccelerometerMax = 7f; // Metadata: 0x00631303
		public const float AngularVelocityMax = 5f; // Metadata: 0x00631307
		public long deltaTimeNanoSeconds; // 0x10
		public long samplingNumber; // 0x18
		public Float3 acceleration; // 0x20
		public Float3 angularVelocity; // 0x2C
		public Float3 angle; // 0x38
		public DirectionState direction; // 0x44
		public SixAxisSensorAttribute attributes; // 0x68
	
		// Methods
		public override string ToString() => default; // 0x00A1D220-0x00A1D230
		public void GetQuaternion(ref float x, ref float y, ref float z, ref float w) {} // 0x00A1D240-0x00A1D250
		public void GetQuaternion(ref Float4 quaternion) {} // 0x00A1D250-0x00A1D270
		private static extern void GetQuaternion(ref SixAxisSensorState state, ref float pOutX, ref float pOutY, ref float pOutZ, ref float pOutW); // 0x00A1D230-0x00A1D240
	}
}
