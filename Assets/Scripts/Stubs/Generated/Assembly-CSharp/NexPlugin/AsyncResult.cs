/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace NexPlugin
{
	public class AsyncResult // TypeDefIndex: 9238
	{
		// Fields
		public uint asyncId; // 0x10
		public AsyncResultNum asyncNum; // 0x14
		public Result nnResult; // 0x18
		public uint netErrCode; // 0x1C
		public int returnCode; // 0x20
		public uint errorCode; // 0x24
	
		// Constructors
		public AsyncResult() {} // 0x00F90DA0-0x00F90DB0
	
		// Methods
		public bool IsSuccess() => default; // 0x00F8D1A0-0x00F8D1F0
		public bool IsFailure() => default; // 0x00F90A00-0x00F90A50
		public void Trace() {} // 0x00F90A50-0x00F90A60
		public override string ToString() => default; // 0x00F90A60-0x00F90DA0
	}
}
