/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;
using nn.account;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.fs
{
	public static class SaveData // TypeDefIndex: 9145
	{
		// Properties
		public static ErrorRange ResultUsableSpaceNotEnoughForSaveData { get; } // 0x00A15FA0-0x00A15FB0 
	
		// Methods
		public static extern Result Ensure(Uid user); // 0x00A15FB0-0x00A15FD0
		public static extern Result Mount(string name, Uid user); // 0x00A15FD0-0x00A16020
		public static extern Result MountSaveDataReadOnly(string name, ulong applicationId, Uid user); // 0x00A16020-0x00A16080
		public static extern bool IsExisting(Uid user); // 0x00A16080-0x00A160A0
		public static extern bool IsExisting(ulong applicationId, Uid user); // 0x00A160A0-0x00A160C0
		public static void SetRootPath(string rootPath) {} // 0x00A160C0-0x00A160D0
		public static Result MountForDebug(string name) => default; // 0x00A160D0-0x00A160E0
	}
}
