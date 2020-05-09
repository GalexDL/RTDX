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
	public class ImageTransferProcessorManager // TypeDefIndex: 9000
	{
		// Fields
		private ImageTransferProcessorState state; // 0x10
		private IntPtr pWorkBuffer; // 0x28
		private long workBufferSize; // 0x30
		private ImageTransferProcessorExConfig config; // 0x38
		private IrCameraHandle handle; // 0x60
	
		// Properties
		public ImageTransferProcessorState State { get => default; } // 0x0114FFD0-0x0114FFE0 
		public byte[] ImageBuffer { get; private set; } // 0x0114FFE0-0x0114FFF0 0x0114FFF0-0x01150000
	
		// Constructors
		public ImageTransferProcessorManager() {} // 0x01150530-0x01150580
	
		// Methods
		~ImageTransferProcessorManager() {} // 0x01150000-0x011500C0
		public void Initialize(IrCameraHandle handle, ImageTransferProcessorFormat format) {} // 0x01150130-0x011501A0
		public void Initialize(IrCameraHandle handle, ImageTransferProcessorConfig config) {} // 0x011502D0-0x01150310
		public void Initialize(IrCameraHandle handle, ImageTransferProcessorExConfig config) {} // 0x011501A0-0x011502D0
		public void Destroy() {} // 0x01150310-0x011503E0
		public bool IsRunning() => default; // 0x011503E0-0x01150400
		public void Run() {} // 0x01150400-0x01150450
		public Result Update() => default; // 0x01150450-0x011504F0
		public void Stop() {} // 0x011504F0-0x01150530
		private void _Destroy() {} // 0x011500C0-0x01150130
	}
}
