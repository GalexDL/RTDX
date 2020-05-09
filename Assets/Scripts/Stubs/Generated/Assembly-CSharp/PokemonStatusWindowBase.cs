/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonStatusWindowBase : UIWindowBase // TypeDefIndex: 6353
{
	// Fields
	private CallbackAction callbackFunc_; // 0x30

	// Nested types
	public enum ActionType // TypeDefIndex: 6354
	{
		TabNext = 0,
		TabPrev = 1,
		ModeChange = 2
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6355; 0x00C5D830-0x00C5DBF0

	// Constructors
	public PokemonStatusWindowBase() {} // 0x00C571C0-0x00C571D0

	// Methods
	public override void Init(GameObject root) {} // 0x00C53A20-0x00C53A30
	protected override void _doUpdate() {} // 0x00C5D670-0x00C5D710
	protected virtual void _doModeChange() {} // 0x00C5D710-0x00C5D730
	public void ResetActionListener() {} // 0x00C57720-0x00C57730
	public void RegisterActionListener(CallbackAction cb) {} // 0x00C57740-0x00C57830
	public void UnregisterActionListener(CallbackAction cb) {} // 0x00C5D740-0x00C5D830
	public void callAction(ActionType action) {} // 0x00C5D730-0x00C5D740
}

