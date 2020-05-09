/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using nn;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace nn.fs
{
	public static class File // TypeDefIndex: 9139
	{
		// Methods
		public static extern Result Read(FileHandle handle, long offset, byte[] buffer, long size, ReadOption option); // 0x00A158D0-0x00A15900
		public static extern Result Read(FileHandle handle, long offset, byte[] buffer, long size); // 0x00A15900-0x00A15930
		public static extern Result Read(ref long outValue, FileHandle handle, long offset, byte[] buffer, long size, ReadOption option); // 0x00A15930-0x00A15960
		public static extern Result Read(ref long outValue, FileHandle handle, long offset, byte[] buffer, long size); // 0x00A15960-0x00A15990
		public static extern Result Write(FileHandle handle, long offset, byte[] buffer, long size, WriteOption option); // 0x00A15990-0x00A159C0
		public static extern Result Flush(FileHandle handle); // 0x00A159C0-0x00A159E0
		public static extern Result SetSize(FileHandle handle, long size); // 0x00A159E0-0x00A15A00
		public static extern Result GetSize(ref long outValue, FileHandle handle); // 0x00A15A00-0x00A15A20
		public static extern OpenFileMode GetOpenMode(FileHandle handle); // 0x00A15A20-0x00A15A30
		public static extern void Close(FileHandle handle); // 0x00A15A30-0x00A15A40
		public static extern Result Create(string path, long size); // 0x00A15A40-0x00A15A80
		public static extern Result Delete(string path); // 0x00A15A80-0x00A15AC0
		public static extern Result Rename(string currentPath, string newPath); // 0x00A15AC0-0x00A15B20
		public static extern Result Open(ref FileHandle outValue, string path, OpenFileMode mode); // 0x00A15B20-0x00A15B80
	}
}
