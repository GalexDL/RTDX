/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// Image 23: UnityEngine.SwitchModule.dll - Assembly: UnityEngine.SwitchModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3428-3443

namespace UnityEngine.Switch
{
	public static class Performance // TypeDefIndex: 3436
	{
		// Nested types
		public enum PerformanceConfiguration // TypeDefIndex: 3437
		{
			Invalid = 0,
			Cpu1020MhzGpu768MhzEmc1600Mhz = 65537,
			Cpu1020MhzGpu307MhzEmc1331Mhz = 131075,
			Cpu1020MhzGpu384MhzEmc1331Mhz = 131076
		}
	
		// Methods
		public static void SetConfiguration(PerformanceConfiguration config) {} // 0x0051EB00-0x0051EC30
		// [NativeConditional] // 0x005EE620-0x005EE680
		private static void SetConfiguration_Internal(PerformanceConfiguration config) {} // 0x0051EC30-0x0051ECA0
	}
}
