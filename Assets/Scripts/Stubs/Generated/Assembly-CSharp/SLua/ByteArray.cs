/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace SLua
{
	public class ByteArray // TypeDefIndex: 8204
	{
		// Fields
		private byte[] data_; // 0x10
		private int pos_; // 0x18
	
		// Properties
		public int Length { get => default; } // 0x00837F00-0x00837F10 
		public int Position { get => default; set {} } // 0x00837F10-0x00837F20 0x00837F20-0x00837F30
	
		// Constructors
		public ByteArray() {} // 0x00837E30-0x00837EA0
		public ByteArray(byte[] data) {} // 0x00837EA0-0x00837ED0
	
		// Methods
		private static void ReAlloc(ref byte[] ba, int pos, int size) {} // 0x00837DA0-0x00837E30
		public void SetData(byte[] data) {} // 0x00837ED0-0x00837EE0
		public void SetData(byte[] data, int len, int pos) {} // 0x00837EE0-0x00837EF0
		public void Clear() {} // 0x00837EF0-0x00837F00
		public byte[] GetData() => default; // 0x00837F30-0x00837F40
		public bool ReadBool() => default; // 0x00837F40-0x00837FA0
		public int ReadInt() => default; // 0x00837FF0-0x00838070
		public uint ReadUInt() => default; // 0x00838070-0x008380F0
		public sbyte ReadChar() => default; // 0x008380F0-0x00838170
		public byte ReadUChar() => default; // 0x008381F0-0x00838240
		public byte ReadByte() => default; // 0x00837FA0-0x00837FF0
		public void Read(ref byte[] arr) {} // 0x00838240-0x008382F0
		public sbyte ReadSByte() => default; // 0x00838170-0x008381F0
		public short ReadShort() => default; // 0x008382F0-0x00838370
		public ushort ReadUShort() => default; // 0x008383F0-0x00838470
		public short ReadInt16() => default; // 0x00838370-0x008383F0
		public ushort ReadUInt16() => default; // 0x00838470-0x008384F0
		public long ReadInt64() => default; // 0x008384F0-0x00838570
		public float ReadFloat() => default; // 0x00838570-0x008385F0
		public double ReadDouble() => default; // 0x008385F0-0x00838670
		public string ReadString() => default; // 0x00838670-0x008386D0
		public void WriteByteArray(ByteArray v) {} // 0x008387A0-0x00838860
		public void WriteBool(bool v) {} // 0x00838920-0x00838930
		public void WriteInt(int v) {} // 0x00838A70-0x00838A80
		public void Write(ByteArray v) {} // 0x00838860-0x00838920
		public void Write(bool v) {} // 0x00838930-0x00838A70
		public void Write(int v) {} // 0x00838A80-0x00838B80
		public void Write(uint v) {} // 0x00838C60-0x00838D60
		public void WriteUInt(uint v) {} // 0x00838D60-0x00838D70
		public void Write(char v) {} // 0x00838D70-0x00838E50
		public void WriteChar(sbyte v) {} // 0x00838E50-0x00838E60
		public void Write(byte[] arr) {} // 0x00838E70-0x00838F80
		public void Write(byte v) {} // 0x00838B80-0x00838C60
		public void WriteByte(byte v) {} // 0x00838F80-0x00839060
		public void WriteUChar(byte v) {} // 0x00839060-0x00839140
		public void Write(sbyte v) {} // 0x00839140-0x00839230
		public void WriteSByte(sbyte v) {} // 0x00838E60-0x00838E70
		public void Write(short v) {} // 0x00839230-0x00839330
		public void Write(ushort v) {} // 0x00839330-0x00839340
		public void WriteUShort(ushort v) {} // 0x00839340-0x00839350
		public void WriteShort(short v) {} // 0x00839350-0x00839360
		public void Write(float v) {} // 0x00839360-0x00839460
		public void WriteFloat(float v) {} // 0x00839460-0x00839470
		public void Write(double v) {} // 0x00839470-0x00839570
		public void WriteNum(double v) {} // 0x00839570-0x00839580
		public void Write(string v) {} // 0x00839580-0x00839660
		public void WriteString(string v) {} // 0x00839810-0x00839820
		public void WriteUInt(uint v, int pos) {} // 0x00839820-0x008398B0
		public void Write(long v) {} // 0x008398B0-0x00839950
		public void WriteInt64(long v) {} // 0x00839950-0x008399F0
		public long ReadVarInt() => default; // 0x008386D0-0x008387A0
		public void WriteVarInt(long v) {} // 0x00839660-0x00839810
		public long ReadInt48() => default; // 0x008399F0-0x00839AF0
		public long ReadInt48L() => default; // 0x00839AF0-0x00839BF0
		public void WriteInt48(long v) {} // 0x00839BF0-0x00839C90
		public ByteArray ReadByteArray() => default; // 0x00839C90-0x00839DF0
		public ulong ReadUInt64() => default; // 0x00839DF0-0x00839E70
		public byte[] ReadBytes() => default; // 0x00839E70-0x00839FD0
		public void WriteBytes(byte[] v) {} // 0x00839FD0-0x0083A090
	}
}
