/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace Pegasus
{
	public class DebugPerformanceCounter : MonoBehaviour // TypeDefIndex: 8493
	{
		// Nested types
		public enum Category // TypeDefIndex: 8494
		{
			Other = 0,
			Character = 1,
			Ground = 2,
			Physics = 3,
			AI = 4,
			PathFinding = 5,
			Camera = 6,
			Map = 7,
			Count = 8
		}
	
		// Constructors
		public DebugPerformanceCounter() {} // 0x00B60030-0x00B60040
	
		// Methods
		// [Conditional] // 0x0063BDC0-0x0063BE00
		public static void BeginSample(Category category, string label = "" /* Metadata: 0x00614B89 */) {} // 0x00B60010-0x00B60020
		// [Conditional] // 0x0063BE00-0x0063BE40
		public static void EndSample() {} // 0x00B60020-0x00B60030
	}
}
