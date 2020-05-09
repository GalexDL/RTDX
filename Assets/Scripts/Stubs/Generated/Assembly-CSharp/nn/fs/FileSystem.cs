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
	public static class FileSystem // TypeDefIndex: 9141
	{
		// Fields
		public const int MountNameLengthMax = 15; // Metadata: 0x006313E7
	
		// Properties
		public static ErrorRange ResultHandledByAllProcess { get; } // 0x00A15C00-0x00A15C10 
		public static ErrorRange ResultPathNotFound { get; } // 0x00A15C10-0x00A15C20 
		public static ErrorRange ResultPathAlreadyExists { get; } // 0x00A15C20-0x00A15C30 
		public static ErrorRange ResultTargetLocked { get; } // 0x00A15C30-0x00A15C40 
		public static ErrorRange ResultDirectoryNotEmpty { get; } // 0x00A15C40-0x00A15C50 
		public static ErrorRange ResultDirectoryStatusChanged { get; } // 0x00A15C50-0x00A15C60 
		public static ErrorRange ResultUsableSpaceNotEnough { get; } // 0x00A15C60-0x00A15C70 
		public static ErrorRange ResultUnsupportedSdkVersion { get; } // 0x00A15C70-0x00A15C80 
		public static ErrorRange ResultMountNameAlreadyExists { get; } // 0x00A15C80-0x00A15C90 
		public static ErrorRange ResultTargetNotFound { get; } // 0x00A15C90-0x00A15CA0 
	
		// Methods
		public static extern Result GetEntryType(ref EntryType outValue, string path); // 0x00A15B80-0x00A15BD0
		public static extern void Unmount(string name); // 0x00A15BD0-0x00A15C00
		public static extern Result Commit(string name); // 0x00A15CA0-0x00A15CE0
		private static extern Result Commit(string[] name, int nameCount); // 0x00A15CE0-0x00A15DD0
		public static Result Commit(string[] name) => default; // 0x00A15DD0-0x00A15DF0
	}
}
