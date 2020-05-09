/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;
using nn.err;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.ec
{
	public abstract class ConsumableServiceItemAsyncRequestBase : IDisposable // TypeDefIndex: 9151
	{
		// Fields
		protected IntPtr _consumableServiceItemAsyncRequestBase; // 0x10
		protected bool isDisposed; // 0x18
	
		// Properties
		internal IntPtr Ptr { get; } // 0x00A12B50-0x00A12B60 
	
		// Constructors
		public ConsumableServiceItemAsyncRequestBase() {} // 0x00A12730-0x00A12780
	
		// Methods
		~ConsumableServiceItemAsyncRequestBase() {} // 0x00A12B60-0x00A12C00
		public void Cancel() {} // 0x00A12C40-0x00A12CB0
		public void Wait() {} // 0x00A12CC0-0x00A12D30
		public bool TryWait() => default; // 0x00A12D40-0x00A12DC0
		public ErrorCode GetErrorCode() => default; // 0x00A12DE0-0x00A12E50
		public abstract Result Begin();
		public abstract Result End();
		public void Dispose() {} // 0x00A12E70-0x00A12F50
		private void _Dispose() {} // 0x00A12C00-0x00A12C40
		protected abstract void Free(IntPtr asyncRequestPtr);
		private static extern void Cancel(IntPtr consumableServiceItemAsyncRequestBase); // 0x00A12CB0-0x00A12CC0
		private static extern void Wait(IntPtr consumableServiceItemAsyncRequestBase); // 0x00A12D30-0x00A12D40
		private static extern bool TryWait(IntPtr consumableServiceItemAsyncRequestBase); // 0x00A12DC0-0x00A12DE0
		private static extern ErrorCode GetErrorCode(IntPtr consumableServiceItemAsyncRequestBase); // 0x00A12E60-0x00A12E70
	}
}
