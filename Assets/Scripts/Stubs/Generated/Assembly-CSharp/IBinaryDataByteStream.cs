/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IBinaryDataByteStream // TypeDefIndex: 5065
{
	// Methods
	bool ReadBool();
	int ReadInt32();
	uint ReadUInt32();
	byte ReadByte();
	short ReadInt16();
	ushort ReadUInt16();
	long ReadInt64();
	ulong ReadUInt64();
	float ReadFloat();
	string ReadStringASCII();
	string ReadStringUnicode();
	void WriteBool(bool v);
	void WriteInt32(int v);
	void WriteUInt32(uint v);
	void WriteInt16(int v);
	void WriteUInt16(uint v);
	void WriteInt64(long v);
	void WriteUInt64(ulong v);
	void WriteByte(byte v);
	void WriteFloat(float v);
	void WriteStringASCII(string v);
	void WriteStringUnicode(string v);
}

