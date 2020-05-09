/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class HintManager : Singleton<HintManager> // TypeDefIndex: 5792
{
	// Fields
	private bool bIsDialog_; // 0x10
	private bool bOpen; // 0x11

	// Constructors
	public HintManager() {} // 0x008F1B20-0x008F1B90

	// Methods
	// [IteratorStateMachine] // 0x00621DF0-0x00621E60
	private IEnumerator ExecuteDialog(HintParameter param, int nativeControlId) => default; // 0x008F0800-0x008F0880
	public void ExecuteDialogForNative(uint hash, int nativeControlId) {} // 0x008F08B0-0x008F09C0
	private uint CalcStringHash(string symbol) => default; // 0x008F0C20-0x008F0C90
	public List<HintParameter> PickupDataInfoForMenu() => default; // 0x008F0C90-0x008F1020
	// [IteratorStateMachine] // 0x00621E60-0x00621ED0
	private IEnumerator CheckAndExecuteDialog(HintParameter param) => default; // 0x008F1020-0x008F10A0
	// [IteratorStateMachine] // 0x00621ED0-0x00621F40
	private IEnumerator NoCheckAndExecuteDialog(HintParameter param) => default; // 0x008F10D0-0x008F1150
	private void HintFlagUpdate(HintParameter param) {} // 0x008F1180-0x008F11F0
	public bool CanExecute(HintParameter param) => default; // 0x008F11F0-0x008F1260
	public bool CanExecute(string symbol) => default; // 0x008F1260-0x008F1320
	public bool CanMenuOpen(HintParameter param) => default; // 0x008F1320-0x008F1390
	public bool CanMenuOpen(string symbol) => default; // 0x008F1390-0x008F1450
	public bool IsOpened(HintParameter param) => default; // 0x008F1450-0x008F14C0
	public bool IsOpen(string symbol) => default; // 0x008F14C0-0x008F1580
	// [IteratorStateMachine] // 0x00621F40-0x00621FB0
	public IEnumerator CheckAndExecuteDialog(string symbol) => default; // 0x008F1580-0x008F1600
	// [IteratorStateMachine] // 0x00621FB0-0x00622020
	public IEnumerator NoCheckAndExecuteDialog(string symbol) => default; // 0x008F1630-0x008F16B0
	public void HintFlagUpdate(string symbol) {} // 0x008F16E0-0x008F17F0
	public bool GetKidokuFlag(HintParameter param) => default; // 0x008F17F0-0x008F1860
	public bool GetKidokuFlag(string symbol) => default; // 0x008F1860-0x008F1900
	public void SetKidokuFlag(HintParameter param, bool bEnable) {} // 0x008F1900-0x008F1980
	public void SetKidokuFlag(string symbol, bool bEnable) {} // 0x008F1980-0x008F1A30
	public void AllClearFlag() {} // 0x008F1A30-0x008F1AA0
	public void AllOpenFlag() {} // 0x008F1AA0-0x008F1B10
	public bool IsDialogOpen() => default; // 0x008F1B10-0x008F1B20
}

