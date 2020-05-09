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
	public static class NpadJoy // TypeDefIndex: 9056
	{
		// Properties
		public static ErrorRange ResultDualConnected { get; } // 0x00A1B8F0-0x00A1B900 
		public static ErrorRange ResultSameJoyTypeConnected { get; } // 0x00A1B900-0x00A1B910 
	
		// Methods
		public static extern NpadJoyAssignmentMode GetAssignment(NpadId npadId); // 0x00A1B7F0-0x00A1B800
		public static extern void SetAssignmentModeSingle(NpadId npadId); // 0x00A1B800-0x00A1B810
		public static extern void SetAssignmentModeSingle(NpadId npadId, NpadJoyDeviceType deviceType); // 0x00A1B810-0x00A1B820
		public static extern void SetAssignmentModeSingle(ref NpadId pOutValue, NpadId npadId, NpadJoyDeviceType deviceType); // 0x00A1B820-0x00A1B830
		public static extern void SetAssignmentModeDual(NpadId npadId); // 0x00A1B830-0x00A1B840
		public static extern Result MergeSingleAsDual(NpadId npadId1, NpadId npadId2); // 0x00A1B840-0x00A1B860
		public static extern void SwapAssignment(NpadId npadId1, NpadId npadId2); // 0x00A1B860-0x00A1B870
		public static extern void SetHoldType(NpadJoyHoldType holdType); // 0x00A1B870-0x00A1B880
		public static extern NpadJoyHoldType GetHoldType(); // 0x00A1B880-0x00A1B890
		public static extern void StartLrAssignmentMode(); // 0x00A1B890-0x00A1B8A0
		public static extern void StopLrAssignmentMode(); // 0x00A1B8A0-0x00A1B8B0
		public static extern void SetHandheldActivationMode(NpadHandheldActivationMode activationMode); // 0x00A1B8B0-0x00A1B8C0
		public static extern NpadHandheldActivationMode GetHandheldActivationMode(); // 0x00A1B8C0-0x00A1B8D0
		public static extern void SetCommunicationMode(NpadCommunicationMode mode); // 0x00A1B8D0-0x00A1B8E0
		public static extern NpadCommunicationMode GetCommunicationMode(); // 0x00A1B8E0-0x00A1B8F0
	}
}
