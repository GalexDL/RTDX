/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using SLua;

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

[CustomLuaClass] // 0x00608C50-0x00608C60
public class TextID // TypeDefIndex: 4545
{
	// Fields
	public static TextMode Mode; // 0x00
	public TextId textId; // 0x10
	public string editLogMark; // 0x18
	public string rawText; // 0x20

	// Nested types
	public enum TextMode // TypeDefIndex: 4546
	{
		EditorMode = 0,
		RomMode = 1
	}

	private enum CastIndex // TypeDefIndex: 4547
	{
		CAST_NONE = 0,
		INDEX_HERO = 1,
		INDEX_PARTNER = 2,
		INDEX_PLAYER = 3,
		INDEX_IRAI1 = 4,
		INDEX_IRAI2 = 5
	}

	// Constructors
	public TextID() {} // Dummy constructor
	public TextID(string gmmId_, string editLogMark_, string rawText_) {} // 0x00921CE0-0x00921DC0
	public TextID(TextId textId) {} // 0x00921DC0-0x00921E80
	static TextID() {} // 0x00922740-0x009227A0

	// Methods
	private int GmmIdToHash_(string gmmId) => default; // 0x00921BC0-0x00921CE0
	public string GetMessage() => default; // 0x00921E80-0x00922130
	private string editorTextModify_(string text) => default; // 0x00922130-0x009226D0
}