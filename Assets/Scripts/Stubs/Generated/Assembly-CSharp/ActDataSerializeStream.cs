/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ActDataSerializeStream // TypeDefIndex: 4405
{
	// Fields
	public Queue<string> serializeData; // 0x10

	// Constructors
	public ActDataSerializeStream() {} // 0x00AA69A0-0x00AA6A10
	public ActDataSerializeStream(string serializeText) {} // 0x00AA6A10-0x00AA6B50

	// Methods
	public override string ToString() => default; // 0x00AA6CC0-0x00AA6EB0
	private string escape_(string data) => default; // 0x00AA6EB0-0x00AA6F30
	private string unescape_(string escData) => default; // 0x00AA6B50-0x00AA6CC0
	public bool IsEmpty() => default; // 0x00AA6F30-0x00AA6F90
	public void Write(string data) {} // 0x00AA6F90-0x00AA6FF0
	public string Read() => default; // 0x00AA6FF0-0x00AA7040
	public void Read(ref string data) {} // 0x00AA7040-0x00AA70B0
	public void WriteT<T>(T data)
		where T : IConvertible {}
	public T ReadT<T>()
		where T : IConvertible => default;
	public void ReadT<T>(ref T data)
		where T : IConvertible {}
	public void WriteUnityJson(object obj) {} // 0x00AA70B0-0x00AA7120
	public void ReadUnityJson(object obj) {} // 0x00AA7120-0x00AA71B0
}

