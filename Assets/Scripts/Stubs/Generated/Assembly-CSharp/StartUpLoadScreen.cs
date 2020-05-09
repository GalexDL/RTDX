/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class StartUpLoadScreen : UIManagerBase // TypeDefIndex: 5715
{
	// Fields
	private static StartUpLoadScreen menu_; // 0x00
	private GameObject BlackScreen; // 0x20
	private bool bLoadFailed; // 0x28

	// Properties
	public static StartUpLoadScreen Instance { get => default; } // 0x00913DC0-0x00913E10 
	public static bool IsValid { get => default; } // 0x00913E10-0x00913E90 
	public bool TrialLoadFailed { get => default; set {} } // 0x00913E90-0x00913EA0 0x00913EA0-0x00913EB0

	// Constructors
	public StartUpLoadScreen() {} // 0x00913F30-0x00913F40

	// Methods
	public static StartUpLoadScreen Create() => default; // 0x00913AA0-0x00913C00
	public static void Delete() {} // 0x00913CE0-0x00913DC0
	public void Construct() {} // 0x00913C00-0x00913CE0
	public void Open() {} // 0x00913EB0-0x00913ED0
	public void Close() {} // 0x00913ED0-0x00913F10
	public void OpenBlackScreen() {} // 0x00913F20-0x00913F30
	public void CloseBlackScreen() {} // 0x00913F10-0x00913F20
}

