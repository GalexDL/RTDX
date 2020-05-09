/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public struct VibrationValue // TypeDefIndex: 9131
	{
		// Fields
		public const int FrequencyLowDefault = 160; // Metadata: 0x006313C7
		public const int FrequencyHighDefault = 320; // Metadata: 0x006313CB
		public float amplitudeLow; // 0x10
		public float frequencyLow; // 0x14
		public float amplitudeHigh; // 0x18
		public float frequencyHigh; // 0x1C
	
		// Constructors
		public VibrationValue(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) {
			this.amplitudeLow = default;
			this.frequencyLow = default;
			this.amplitudeHigh = default;
			this.frequencyHigh = default;
		} // 0x011457C0-0x011457E0
	
		// Methods
		public static VibrationValue Make() => default; // 0x01145790-0x011457B0
		public static VibrationValue Make(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) => default; // 0x011457B0-0x011457C0
		public void Set(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh) {} // 0x011457E0-0x01145800
		public void Clear() {} // 0x01145800-0x01145A50
		public override string ToString() => default; // 0x01145A50-0x01145D20
	}
}
