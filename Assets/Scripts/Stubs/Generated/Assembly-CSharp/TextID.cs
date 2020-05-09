/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class TextId // TypeDefIndex: 5584
{
	// Fields
	public int hashId; // 0x10
	[Obsolete] // 0x006168A0-0x006168B0
	public string debugRawText; // 0x18
	private string replacedRawText_; // 0x20

	// Properties
	public bool IsValid { get => default; } // 0x00923060-0x00923070 

	// Constructors
	public TextId() {} // 0x0091CE10-0x0091CE70
	public TextId(TextIDHash hashId_) {} // 0x00914630-0x009146A0
	public TextId(int hashId_) {} // 0x00922EB0-0x00922F20
	public TextId(string label) {} // 0x0091DAA0-0x0091DB80

	// Methods
	public static explicit operator TextId(TextIDHash hashId) => default; // 0x00922FB0-0x00923060
	public void SetReplacedRawText(string text) {} // 0x0091CE70-0x0091CE80
	public string GetReplacedRawText() => default; // 0x00923070-0x00923080
	public string GetText() => default; // 0x0091CBB0-0x0091CC30
	public static int LabelToHash(string label) => default; // 0x00922F20-0x00922FB0
}

public class TextID
{
	
}