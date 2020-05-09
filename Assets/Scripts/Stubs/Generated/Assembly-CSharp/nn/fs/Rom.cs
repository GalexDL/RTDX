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
	public static class Rom // TypeDefIndex: 9146
	{
		// Properties
		public static ErrorRange ResultRomHostFileSystemCorrupted { get; } // 0x00A15EC0-0x00A15ED0 
		public static ErrorRange ResultRomHostEntryCorrupted { get; } // 0x00A15ED0-0x00A15EE0 
		public static ErrorRange ResultRomHostFileDataCorrupted { get; } // 0x00A15EE0-0x00A15EF0 
		public static ErrorRange ResultRomHostFileCorrupted { get; } // 0x00A15EF0-0x00A15F00 
		public static ErrorRange ResultInvalidRomHostHandle { get; } // 0x00A15F00-0x00A15F10 
	
		// Methods
		public static extern Result QueryMountRomCacheSize(ref long pOutValue); // 0x00A15F10-0x00A15F30
		public static extern Result MountRom(string name, byte[] pFileSystemCacheBuffer, long fileSystemCacheBufferSize); // 0x00A15F30-0x00A15F90
		public static bool CanMountRomForDebug() => default; // 0x00A15F90-0x00A15FA0
	}
}
