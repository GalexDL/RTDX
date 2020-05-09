/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.hid
{
	public static class TouchScreen // TypeDefIndex: 9120
	{
		// Fields
		public const int TouchCountMax = 16; // Metadata: 0x006313A7
		public const int StateCountMax = 16; // Metadata: 0x006313AB
	
		// Methods
		public static extern void Initialize(); // 0x00A1D270-0x00A1D280
		public static extern void GetState(ref TouchScreenState1 pOutValue); // 0x00A1D280-0x00A1D290
		public static extern void GetState(ref TouchScreenState2 pOutValue); // 0x00A1D290-0x00A1D2A0
		public static extern void GetState(ref TouchScreenState3 pOutValue); // 0x00A1D2A0-0x00A1D2B0
		public static extern void GetState(ref TouchScreenState4 pOutValue); // 0x00A1D2B0-0x00A1D2C0
		public static extern void GetState(ref TouchScreenState5 pOutValue); // 0x00A1D2C0-0x00A1D2D0
		public static extern void GetState(ref TouchScreenState6 pOutValue); // 0x00A1D2D0-0x00A1D2E0
		public static extern void GetState(ref TouchScreenState7 pOutValue); // 0x00A1D2E0-0x00A1D2F0
		public static extern void GetState(ref TouchScreenState8 pOutValue); // 0x00A1D2F0-0x00A1D300
		public static extern void GetState(ref TouchScreenState9 pOutValue); // 0x00A1D300-0x00A1D310
		public static extern void GetState(ref TouchScreenState10 pOutValue); // 0x00A1D310-0x00A1D320
		public static extern void GetState(ref TouchScreenState11 pOutValue); // 0x00A1D320-0x00A1D330
		public static extern void GetState(ref TouchScreenState12 pOutValue); // 0x00A1D330-0x00A1D340
		public static extern void GetState(ref TouchScreenState13 pOutValue); // 0x00A1D340-0x00A1D350
		public static extern void GetState(ref TouchScreenState14 pOutValue); // 0x00A1D350-0x00A1D360
		public static extern void GetState(ref TouchScreenState15 pOutValue); // 0x00A1D360-0x00A1D370
		public static extern void GetState(ref TouchScreenState16 pOutValue); // 0x00A1D370-0x00A1D380
		public static extern int GetStates(out TouchScreenState1[] pOutValues, int count); // 0x00A1D380-0x00A1D4A0
		public static extern int GetStates(out TouchScreenState2[] pOutValues, int count); // 0x00A1D4A0-0x00A1D5C0
		public static extern int GetStates(out TouchScreenState3[] pOutValues, int count); // 0x00A1D5C0-0x00A1D6F0
		public static extern int GetStates(out TouchScreenState4[] pOutValues, int count); // 0x00A1D6F0-0x00A1D820
		public static extern int GetStates(out TouchScreenState5[] pOutValues, int count); // 0x00A1D820-0x00A1D950
		public static extern int GetStates(out TouchScreenState6[] pOutValues, int count); // 0x00A1D950-0x00A1DAA0
		public static extern int GetStates(out TouchScreenState7[] pOutValues, int count); // 0x00A1DAA0-0x00A1DBD0
		public static extern int GetStates(out TouchScreenState8[] pOutValues, int count); // 0x00A1DBD0-0x00A1DD00
		public static extern int GetStates(out TouchScreenState9[] pOutValues, int count); // 0x00A1DD00-0x00A1DE30
		public static extern int GetStates(out TouchScreenState10[] pOutValues, int count); // 0x00A1DE30-0x00A1DF60
		public static extern int GetStates(out TouchScreenState11[] pOutValues, int count); // 0x00A1DF60-0x00A1E090
		public static extern int GetStates(out TouchScreenState12[] pOutValues, int count); // 0x00A1E090-0x00A1E1B0
		public static extern int GetStates(out TouchScreenState13[] pOutValues, int count); // 0x00A1E1B0-0x00A1E2E0
		public static extern int GetStates(out TouchScreenState14[] pOutValues, int count); // 0x00A1E2E0-0x00A1E410
		public static extern int GetStates(out TouchScreenState15[] pOutValues, int count); // 0x00A1E410-0x00A1E540
		public static extern int GetStates(out TouchScreenState16[] pOutValues, int count); // 0x00A1E540-0x00A1E670
	}
}
