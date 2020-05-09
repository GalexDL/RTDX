/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.ec
{
	public sealed class AsyncRecoverRightDataRequest : ConsumableServiceItemAsyncRequestBase // TypeDefIndex: 9154
	{
		// Constructors
		public AsyncRecoverRightDataRequest() {} // 0x00A12940-0x00A129A0
	
		// Methods
		protected override void Free(IntPtr asyncRequestPtr) {} // 0x00A129C0-0x00A129D0
		public override Result Begin() => default; // 0x00A129F0-0x00A12A10
		public override Result End() => default; // 0x00A12A30-0x00A12A50
		private static extern Result Begin(IntPtr asyncGetConsumableRightDataRequestBase); // 0x00A12A10-0x00A12A30
		private static extern Result End(IntPtr asyncGetConsumableRightDataRequestBase); // 0x00A12A50-0x00A12AC0
		private static extern Result New(ref IntPtr asyncGetConsumableRightDataRequestBase); // 0x00A129A0-0x00A129C0
		private static extern Result Delete(IntPtr asyncGetConsumableRightDataRequestBase); // 0x00A129D0-0x00A129F0
	}
}
