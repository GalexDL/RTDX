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
	public static class ImageTransferProcessor // TypeDefIndex: 8999
	{
		// Fields
		public const int QvgaImageSize = 76800; // Metadata: 0x0063101B
		public const int QqvgaImageSize = 19200; // Metadata: 0x0063101F
		public const int QqqvgaImageSize = 4800; // Metadata: 0x00631023
		public const int ImageSize320x240 = 76800; // Metadata: 0x00631027
		public const int ImageSize160x120 = 19200; // Metadata: 0x0063102B
		public const int ImageSize80x60 = 4800; // Metadata: 0x0063102F
		public const int ImageSize40x30 = 1200; // Metadata: 0x00631033
		public const int ImageSize20x15 = 300; // Metadata: 0x00631037
		public const int QvgaWorkBufferSize = 155648; // Metadata: 0x0063103B
		public const int QqvgaWorkBufferSize = 40960; // Metadata: 0x0063103F
		public const int QqqvgaWorkBufferSize = 12288; // Metadata: 0x00631043
		public const int WorkBufferSize320x240 = 155648; // Metadata: 0x00631047
		public const int WorkBufferSize160x120 = 40960; // Metadata: 0x0063104B
		public const int WorkBufferSize80x60 = 12288; // Metadata: 0x0063104F
		public const int WorkBufferSize40x30 = 4096; // Metadata: 0x00631053
		public const int WorkBufferSize20x15 = 4096; // Metadata: 0x00631057
		public const long ExposureTimeMinNanoSeconds = 7000; // Metadata: 0x0063105B
		public const long ExposureTimeMaxNanoSeconds = 600000; // Metadata: 0x00631063
	
		// Methods
		public static extern void GetDefaultConfig(ref ImageTransferProcessorConfig pOutValue); // 0x0114FDD0-0x0114FDE0
		public static extern void GetDefaultConfig(ref ImageTransferProcessorExConfig pOutValue); // 0x0114FDE0-0x0114FDF0
		public static extern void Run(IrCameraHandle handle, ImageTransferProcessorConfig config, IntPtr workBuffer, long workBufferSize); // 0x0114FDF0-0x0114FE30
		public static extern void Run(IrCameraHandle handle, ImageTransferProcessorExConfig config, IntPtr workBuffer, long workBufferSize); // 0x0114FE30-0x0114FE70
		public static extern Result GetState(ref ImageTransferProcessorState pOutState, IntPtr pOutImage, long size, IrCameraHandle handle); // 0x0114FE70-0x0114FE90
		public static extern void InitializeWorkBuffer(ref IntPtr pOutWorkBuffer, ref long pOutWorkBufferSize, ImageTransferProcessorConfig config); // 0x0114FE90-0x0114FEC0
		public static extern void InitializeWorkBuffer(ref IntPtr pOutWorkBuffer, ref long pOutWorkBufferSize, ImageTransferProcessorExConfig config); // 0x0114FEC0-0x0114FF00
		public static extern void DestroyWorkBuffer(IntPtr workBuffer); // 0x0114FF00-0x0114FF10
		public static int GetWorkBufferSize(ImageTransferProcessorFormat format) => default; // 0x0114FF10-0x0114FF40
		public static int GetImageSize(ImageTransferProcessorFormat format) => default; // 0x0114FF40-0x0114FF70
		public static int GetImageWidth(ImageTransferProcessorFormat format) => default; // 0x0114FF70-0x0114FFA0
		public static int GetImageHeight(ImageTransferProcessorFormat format) => default; // 0x0114FFA0-0x0114FFD0
	}
}
