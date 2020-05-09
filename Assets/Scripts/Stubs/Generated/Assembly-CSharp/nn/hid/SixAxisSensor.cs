/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class SixAxisSensor // TypeDefIndex: 9069
	{
		// Fields
		public const int StateCountMax = 16; // Metadata: 0x00631317
		public const int HandleCountMax = 8; // Metadata: 0x0063131B
	
		// Methods
		public static extern int GetHandles(SixAxisSensorHandle[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle); // 0x00A1CC10-0x00A1CC20
		public static extern void Start(SixAxisSensorHandle handle); // 0x00A1CC20-0x00A1CC30
		public static extern void Stop(SixAxisSensorHandle handle); // 0x00A1CC30-0x00A1CC40
		public static extern bool IsRest(SixAxisSensorHandle handle); // 0x00A1CC40-0x00A1CC60
		public static extern void GetState(ref SixAxisSensorState pOutValue, SixAxisSensorHandle handle); // 0x00A1CC60-0x00A1CC70
		public static extern int GetStates(out SixAxisSensorState[] pOutValues, int count, SixAxisSensorHandle handle); // 0x00A1CC70-0x00A1CDA0
		public static extern bool IsFusionEnabled(SixAxisSensorHandle handle); // 0x00A1CDA0-0x00A1CDC0
		public static extern void EnableFusion(SixAxisSensorHandle handle, bool enable); // 0x00A1CDC0-0x00A1CDD0
		public static extern void SetFusionParameters(SixAxisSensorHandle handle, float revisePower, float reviseRange); // 0x00A1CDD0-0x00A1CDE0
		public static extern void GetFusionParameters(ref float pOutRevisePower, ref float pOutReviseRange, SixAxisSensorHandle handle); // 0x00A1CDE0-0x00A1CDF0
		public static extern void ResetFusionParameters(SixAxisSensorHandle handle); // 0x00A1CDF0-0x00A1CE00
		public static extern void SetGyroscopeZeroDriftMode(SixAxisSensorHandle handle, GyroscopeZeroDriftMode mode); // 0x00A1CE00-0x00A1CE10
		public static extern GyroscopeZeroDriftMode GetGyroscopeZeroDriftMode(SixAxisSensorHandle handle); // 0x00A1CE10-0x00A1CE20
		public static extern bool IsFirmwareUpdateAvailableForSixAxisSensor(SixAxisSensorHandle handle); // 0x00A1CE20-0x00A1D220
	}
}
