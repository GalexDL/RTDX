/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public abstract class SimpleMenuBase // TypeDefIndex: 8018
{
	// Fields
	public TextId textId; // 0x10
	public Func<TextId> textFunc; // 0x18

	// Properties
	public TextId text { get; } // 0x009E6C60-0x009E6CD0 

	// Nested types
	public enum MenuResult // TypeDefIndex: 8019
	{
		None = 0,
		MenuEnd = 1
	}

	// Constructors
	protected SimpleMenuBase() {} // 0x009E5E80-0x009E5EF0

	// Methods
	public abstract IEnumerator MenuFlow(Action<MenuResult> resultCb);
}

