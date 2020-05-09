/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class Npad // TypeDefIndex: 9044
	{
		// Fields
		public const int StateCountMax = 16; // Metadata: 0x006312C3
	
		// Properties
		public static ErrorRange ResultColorNotAvailable { get; } // 0x00A1AED0-0x00A1AEE0 
		public static ErrorRange ResultControllerNotConnected { get; } // 0x00A1AEE0-0x00A1AEF0 
	
		// Methods
		public static extern void Initialize(); // 0x00A1A230-0x00A1A240
		public static extern void SetSupportedStyleSet(NpadStyle npadStyle); // 0x00A1A240-0x00A1A250
		public static extern NpadStyle GetSupportedStyleSet(); // 0x00A1A250-0x00A1A260
		public static extern void SetSupportedIdType(NpadId[] npadIds, long count); // 0x00A1A260-0x00A1A270
		public static void SetSupportedIdType(NpadId[] npadIds) {} // 0x00A1A270-0x00A1A290
		public static extern void BindStyleSetUpdateEvent(NpadId npadId); // 0x00A1A290-0x00A1A2A0
		public static extern bool IsStyleSetUpdated(NpadId npadId); // 0x00A1A2A0-0x00A1A2C0
		public static extern void DestroyStyleSetUpdateEvent(NpadId npadId); // 0x00A1A2C0-0x00A1A2D0
		public static extern NpadStyle GetStyleSet(NpadId npadId); // 0x00A1A2D0-0x00A1A2E0
		public static extern void Disconnect(NpadId npadId); // 0x00A1A2E0-0x00A1A2F0
		public static extern byte GetPlayerLedPattern(NpadId npadId); // 0x00A1A2F0-0x00A1A300
		public static extern Result GetControllerColor(ref NpadControllerColor pOutValue, NpadId npadId); // 0x00A1A300-0x00A1A320
		public static extern Result GetControllerColor(ref NpadControllerColor pOutLeftColor, ref NpadControllerColor pOutRightColor, NpadId npadId); // 0x00A1A320-0x00A1A340
		public static void GetState(ref NpadState pOutValue, NpadId npadId, NpadStyle npadStyle) {} // 0x00A1A340-0x00A1A3F0
		public static int GetStates(out NpadStateArrayItem[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle) {
			pOutValues = default;
			return default;
		} // 0x00A1A440-0x00A1A890
	}
}
