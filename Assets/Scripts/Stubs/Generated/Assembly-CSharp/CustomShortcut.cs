/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class CustomShortcut : SingletonMonoBehaviour<CustomShortcut> // TypeDefIndex: 5784
{
	// Fields
	public GameObject objectCtrl_; // 0x18
	private bool is_checked; // 0x20
	private int last_valid; // 0x24

	// Constructors
	public CustomShortcut() {} // 0x0098A5B0-0x0098A620

	// Methods
	public static void Startup() {} // 0x009896D0-0x00989760
	public void Initialize() {} // 0x00989760-0x00989840
	private void Update() {} // 0x00989E50-0x00989F00
	public void CheckCustomShortcut() {} // 0x00989F00-0x0098A040
	public void OpenCustomShortcutMenu() {} // 0x0098A040-0x0098A200
	public void CloseCustomShortcutMenu() {} // 0x0098A530-0x0098A5B0
	public void UpdateShortcutInfo(bool check_status = true /* Metadata: 0x00611F3B */) {} // 0x00989840-0x00989E50
	public bool CheckValidCommand(OptionManager.Shortcut shortcut) => default; // 0x0098A200-0x0098A530
}

