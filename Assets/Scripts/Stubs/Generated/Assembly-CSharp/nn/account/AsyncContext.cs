/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.account
{
	public sealed class AsyncContext : IDisposable // TypeDefIndex: 9172
	{
		// Fields
		internal IntPtr _context; // 0x10
	
		// Constructors
		public AsyncContext() {} // 0x00A100A0-0x00A10100
	
		// Methods
		~AsyncContext() {} // 0x00A10110-0x00A101D0
		public void Dispose() {} // 0x00A10230-0x00A102E0
		private void Dispose(bool disposing) {} // 0x00A101D0-0x00A10230
		public Result Cancel() => default; // 0x00A102F0-0x00A10310
		public Result HasDone(ref bool pOut) => default; // 0x00A10330-0x00A10350
		public Result GetResult() => default; // 0x00A10370-0x00A10390
		private static extern IntPtr Create(); // 0x00A10100-0x00A10110
		private static extern void Destroy(IntPtr context); // 0x00A102E0-0x00A102F0
		private static extern Result Cancel(IntPtr context); // 0x00A10310-0x00A10330
		private static extern Result HasDone(IntPtr context, ref bool pOut); // 0x00A10350-0x00A10370
		private static extern Result GetResult(IntPtr context); // 0x00A10390-0x00A103B0
	}
}
