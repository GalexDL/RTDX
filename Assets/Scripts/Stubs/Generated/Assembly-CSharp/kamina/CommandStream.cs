/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace kamina
{
	public class CommandStream // TypeDefIndex: 8378
	{
		// Fields
		private const int MAX_TEMP_BUFFER = 4096; // Metadata: 0x00614ABB
		private const int MAX_TEMP_STRING = 4096; // Metadata: 0x00614ABF
		private const int ONE_READ_SIZE = 4; // Metadata: 0x00614AC3
		private uint[] arrayPointer_; // 0x10
		private int position_; // 0x18
		private bool bWriteMode_; // 0x1C
		private byte[] aTempString_; // 0x20
		private ushort[] aTempString16_; // 0x28
	
		// Properties
		public bool IsOpen { get => default; } // 0x00B7D4D0-0x00B7D4E0 
		public int Position { get => default; } // 0x00B7D4E0-0x00B7D4F0 
		public int BytePosition { get => default; } // 0x00B7D500-0x00B7D510 
		public uint[] Buffer { get => default; } // 0x00B7D510-0x00B7D520 
		public int BufferSize { get => default; } // 0x00B7D520-0x00B7D530 
	
		// Constructors
		public CommandStream() {} // 0x00B7DE10-0x00B7DE90
	
		// Methods
		public void Open(int size, bool bWriteMode) {} // 0x00B7D440-0x00B7D4B0
		public void Open(uint[] buffer, bool bWriteMode) {} // 0x00B7D4B0-0x00B7D4C0
		public void Close() {} // 0x00B7D4C0-0x00B7D4D0
		public void SetPosition(int v) {} // 0x00B7D4F0-0x00B7D500
		public int ReadByte(byte[] buffer, int count) => default; // 0x00B7D530-0x00B7D600
		public int ReadUInt16(ushort[] buffer, int count) => default; // 0x00B7D600-0x00B7D6F0
		public bool ReadBool() => default; // 0x00B7D6F0-0x00B7D750
		public int ReadS32() => default; // 0x00B7D750-0x00B7D7A0
		public uint ReadU32() => default; // 0x00B7D7A0-0x00B7D7F0
		public float ReadF32() => default; // 0x00B7D7F0-0x00B7D850
		public long ReadS64() => default; // 0x00B7D850-0x00B7D8F0
		public ulong ReadU64() => default; // 0x00B7D8F0-0x00B7D990
		public string ReadString(Encoding encode) => default; // 0x00B7D990-0x00B7DC00
		public string ReadString16() => default; // 0x00B7DC00-0x00B7DE10
	}
}
