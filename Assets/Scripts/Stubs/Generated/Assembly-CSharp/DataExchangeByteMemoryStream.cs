/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DataExchangeByteMemoryStream : IBinaryDataByteStream // TypeDefIndex: 5852
{
	// Fields
	public const int DEFAULT_TEMP_BUFFER_SIZE = 16384; // Metadata: 0x00612114
	public const int MAX_TEMP_BUFFER = 131072; // Metadata: 0x00612118
	private static byte[] s_tempBuffer_; // 0x00
	private byte[] arrayPointer_; // 0x10
	private byte[] aTemp_; // 0x18
	private int position_; // 0x20
	private bool bWriteMode_; // 0x24
	private byte[] tmpBuff4; // 0x28

	// Properties
	public bool IsOpen { get => default; } // 0x0098AEC0-0x0098AED0 
	public long Position { get => default; } // 0x0098AED0-0x0098AEE0 
	public byte[] Buffer { get => default; } // 0x0098AEE0-0x0098AEF0 
	public int BufferSize { get => default; } // 0x0098AEF0-0x0098AF00 

	// Nested types
	public struct Convert32BitType_ // TypeDefIndex: 5853
	{
		// Fields
		public int Int32Value; // 0x10
		public float FloatValue; // 0x10
	}

	// Constructors
	public DataExchangeByteMemoryStream() {} // 0x00986D30-0x00986DD0
	public DataExchangeByteMemoryStream(byte[] aTemp) {} // 0x00984550-0x009845D0
	static DataExchangeByteMemoryStream() {} // 0x0098E2D0-0x0098E340

	// Methods
	public void SetTmpBuffer(byte[] aTemp) {} // 0x0098ADA0-0x0098AE40
	public void Open(int size, bool bWriteMode) {} // 0x0098AE40-0x0098AEC0
	public void Open(byte[] buffer, bool bWriteMode) {} // 0x009845D0-0x009845F0
	public void Close() {} // 0x00986F70-0x00986F80
	public int Read(byte[] buffer, int count) => default; // 0x0098AF00-0x0098AFC0
	public byte ReadByte() => default; // 0x0098AFC0-0x0098B010
	public bool ReadBool() => default; // 0x0098B010-0x0098B070
	public short ReadS16() => default; // 0x0098B070-0x0098B160
	public short ReadInt16() => default; // 0x0098B160-0x0098B170
	public ushort ReadU16() => default; // 0x0098B170-0x0098B260
	public ushort ReadUInt16() => default; // 0x0098B260-0x0098B270
	public int ReadS32() => default; // 0x009845F0-0x00984790
	public int ReadInt32() => default; // 0x0098B270-0x0098B280
	public uint ReadU32() => default; // 0x00986DD0-0x00986F70
	public uint ReadUInt32() => default; // 0x0098B280-0x0098B290
	public long ReadS64() => default; // 0x0098B290-0x0098B580
	public long ReadInt64() => default; // 0x0098B580-0x0098B590
	public ulong ReadU64() => default; // 0x00984790-0x00984A80
	public ulong ReadUInt64() => default; // 0x0098B590-0x0098B5A0
	public float ReadF32() => default; // 0x0098B5A0-0x0098B740
	public float ReadFloat() => default; // 0x0098B740-0x0098B750
	public string ReadString(Encoding encode) => default; // 0x0098B750-0x0098B970
	public string ReadStringASCII() => default; // 0x0098B970-0x0098B9A0
	public string ReadStringUnicode() => default; // 0x0098B9A0-0x0098B9D0
	public void Write(byte[] buffer, int count) {} // 0x0098B9D0-0x0098BA80
	public void WriteByte(byte value) {} // 0x0098BA80-0x0098BAE0
	public void WriteBool(bool value) {} // 0x0098BAE0-0x0098BB40
	public void WriteS16(int value) {} // 0x0098BB40-0x0098BBE0
	public void WriteInt16(int value) {} // 0x0098BBE0-0x0098BC80
	public void WriteUInt16(uint value) {} // 0x0098BC80-0x0098BD20
	public void WriteS32(int value) {} // 0x0098BD20-0x0098BE30
	public void WriteInt32(int value) {} // 0x0098BE30-0x0098BE40
	public void WriteU32(uint value) {} // 0x0098BE40-0x0098BF50
	public void WriteS64(long value) {} // 0x0098BF50-0x0098C140
	public void WriteU64(ulong value) {} // 0x0098C140-0x0098C330
	public void WriteUInt32(uint value) {} // 0x0098C330-0x0098C340
	public void WriteInt64(long value) {} // 0x0098C340-0x0098C350
	public void WriteUInt64(ulong value) {} // 0x0098C350-0x0098C360
	public void WriteF32(float value) {} // 0x0098C360-0x0098C4F0
	public void WriteFloat(float value) {} // 0x0098C5C0-0x0098C5D0
	public void WriteString(string str, Encoding encode) {} // 0x0098C5D0-0x0098C6F0
	public void WriteStringASCII(string str) {} // 0x0098C6F0-0x0098C730
	public void WriteStringUnicode(string str) {} // 0x0098C730-0x0098C770
	public void WriteStringN(string str, Encoding encode, int length) {} // 0x0098C770-0x0098C920
	public void WriteStringNUnicode(string str, int length) {} // 0x0098C920-0x0098C970
	public Vector3 ReadVector3() => default; // 0x0098C970-0x0098C9C0
	public void WriteVector3(Vector3 v) {} // 0x0098C9C0-0x0098CA10
	public Vector4 ReadVector4() => default; // 0x0098CA10-0x0098CA80
	public void WriteVector4(Vector4 v) {} // 0x0098CA80-0x0098CAE0
	public void WriteMatrix44(ref Matrix4x4 value) {} // 0x0098CAE0-0x0098CBC0
	public void WriteConvertNativeCameraMatrix44(ref Matrix4x4 value) {} // 0x0098CBC0-0x0098E2D0
	private byte[] FloatToBytes_(float value) => default; // 0x0098C4F0-0x0098C5C0
}

