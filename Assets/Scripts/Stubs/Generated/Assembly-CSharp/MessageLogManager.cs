/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class MessageLogManager : Singleton<MessageLogManager> // TypeDefIndex: 5814
{
	// Fields
	private List<string> messageList; // 0x10
	private const int MessageLogMaxLine = 150; // Metadata: 0x00611F9D

	// Constructors
	public MessageLogManager() {} // 0x008979D0-0x00897A70

	// Methods
	public void Add2(string message) {} // 0x00896FA0-0x00897210
	public void Add(string message) {} // 0x00897210-0x00897350
	public bool GetLinkExist() => default; // 0x00897350-0x008974D0
	public bool CheckLink(string text) => default; // 0x008974D0-0x00897700
	public List<string> GetList() => default; // 0x00897710-0x00897980
	public void Clear() {} // 0x00897980-0x008979D0
}

