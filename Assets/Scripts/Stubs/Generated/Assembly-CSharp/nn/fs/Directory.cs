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
	public static class Directory // TypeDefIndex: 9135
	{
		// Fields
		public const int EntryNameLengthMax = 768; // Metadata: 0x006313CF
	
		// Methods
		public static extern Result Read(ref long outValue, out DirectoryEntry[] entryBuffer, DirectoryHandle handle, long entryBufferCount); // 0x00A15420-0x00A155A0
		public static extern Result GetEntryCount(ref long outValue, DirectoryHandle handle); // 0x00A155A0-0x00A155C0
		public static extern void Close(DirectoryHandle handle); // 0x00A155C0-0x00A155D0
		public static extern Result Create(string path); // 0x00A155D0-0x00A15610
		public static extern Result Delete(string path); // 0x00A15610-0x00A15650
		public static extern Result DeleteRecursively(string path); // 0x00A15650-0x00A15690
		public static extern Result CleanRecursively(string path); // 0x00A15690-0x00A156D0
		public static extern Result Rename(string currentPath, string newPath); // 0x00A156D0-0x00A15730
		public static extern Result Open(ref DirectoryHandle outValue, string path, OpenDirectoryMode mode); // 0x00A15730-0x00A15800
	}
}
