/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.irsensor
{
	public static class MomentProcessor // TypeDefIndex: 9010
	{
		// Fields
		public const int StateCountMax = 5; // Metadata: 0x006310B7
		public const int BlockColumnCount = 8; // Metadata: 0x006310BB
		public const int BlockRowCount = 6; // Metadata: 0x006310BF
		public const int BlockCount = 48; // Metadata: 0x006310C3
	
		// Methods
		public static extern void GetDefaultConfig(ref MomentProcessorConfig pOutValue); // 0x01150B20-0x01150B30
		public static extern void Run(IrCameraHandle handle, MomentProcessorConfig config); // 0x01150B30-0x01150B70
		public static extern Result GetState(ref MomentProcessorState pOutValue, IrCameraHandle handle); // 0x01150B70-0x01150B90
		public static Result GetStatus(MomentProcessorState[] pOutStates, ref int pOutCount, IrCameraHandle handle) => default; // 0x01150B90-0x01150BC0
		private static extern Result GetStates([In, Out] MomentProcessorState[] pOutStates, ref int pOutCount, int countMax, IrCameraHandle handle); // 0x01150BC0-0x01150BF0
		public static extern MomentStatistic CalculateMomentRegionStatistic(ref MomentProcessorState pState, Rect windowOfInterest, int startRow, int startColumn, int rowCount, int columnCount); // 0x01150BF0-0x01150E60
	}
}
