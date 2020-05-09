/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using nn;
using nn.util;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.irsensor
{
	public static class HandAnalysis // TypeDefIndex: 8973
	{
		// Fields
		public const int ProcessorStateCountMax = 5; // Metadata: 0x00630F8B
		public const int ShapePointCountMax = 512; // Metadata: 0x00630F8F
		public const int ShapeCountMax = 16; // Metadata: 0x00630F93
		public const int ProtrusionCountMax = 8; // Metadata: 0x00630F97
		public const int HandCountMax = 2; // Metadata: 0x00630F9B
		public const int ImageWidth = 40; // Metadata: 0x00630F9F
		public const int ImageHeight = 30; // Metadata: 0x00630FA3
	
		// Methods
		public static extern Result Run(IrCameraHandle handle, HandAnalysisConfig config); // 0x0114C960-0x0114C980
		public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutValue, IrCameraHandle handle); // 0x0114C980-0x0114C9A0
		public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) => default; // 0x0114C9A0-0x0114C9E0
		private static extern Result GetSilhouetteState([In, Out] HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle); // 0x0114C9E0-0x0114CA10
		public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutState, [In, Out] Float2[] pOutPointBuffer, IrCameraHandle handle); // 0x0114CA10-0x0114CA40
		public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutStateArray, Float2[][] pOutPointArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) => default; // 0x0114CA40-0x0114CA50
		private static extern Result GetSilhouetteState([In, Out] HandAnalysisSilhouetteState[] pOutStateArray, [In, Out] Float2[][] pOutPointArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle); // 0x0114CA50-0x0114CA90
		public static extern Result GetImageState(ref HandAnalysisImageState pOutState, [In, Out] ushort[] pOutImageBuffer, IrCameraHandle handle); // 0x0114CA90-0x0114CAC0
		public static Result GetImageState(HandAnalysisImageState[] pOutStateArray, ushort[] pOutImageArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle) => default; // 0x0114CAC0-0x0114CB00
		private static extern Result GetImageState([In, Out] HandAnalysisImageState[] pOutStateArray, [In, Out] ushort[] pOutImageArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle); // 0x0114CB00-0x0114CB40
	}
}
