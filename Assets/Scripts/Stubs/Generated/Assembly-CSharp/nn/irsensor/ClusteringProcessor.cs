/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.irsensor
{
	public static class ClusteringProcessor // TypeDefIndex: 8967
	{
		// Fields
		public const int StateCountMax = 5; // Metadata: 0x00630F67
		public const int ObjectCountMax = 16; // Metadata: 0x00630F6B
		public const int ObjectPixelCountMax = 76800; // Metadata: 0x00630F6F
		public const int OutObjectPixelCountMax = 65535; // Metadata: 0x00630F73
		public const long ExposureTimeMinNanoSeconds = 7000; // Metadata: 0x00630F77
		public const long ExposureTimeMaxNanoSeconds = 600000; // Metadata: 0x00630F7F
	
		// Methods
		public static extern void GetDefaultConfig(ref ClusteringProcessorConfig pOutValue); // 0x01146820-0x01146830
		public static extern void Run(IrCameraHandle handle, ClusteringProcessorConfig config); // 0x01146830-0x01146870
		public static extern Result GetState(ref ClusteringProcessorState pOutValue, IrCameraHandle handle); // 0x01146870-0x01146890
		public static extern Result GetStates(out ClusteringProcessorState[] pOutStates, ref int pOutCount, int countMax, IrCameraHandle handle); // 0x01146890-0x01146F50
	}
}
