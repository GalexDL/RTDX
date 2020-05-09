/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace menuitem
{
	public class MenuSeedUI : MenuOtherUI // TypeDefIndex: 8460
	{
		// Fields
		[SerializeField] // 0x00617190-0x006171A0
		private UIControlTMP[] digitColumn; // 0x28
		[SerializeField] // 0x006171A0-0x006171B0
		private Transform cursorPosition; // 0x30
		[SerializeField] // 0x006171B0-0x006171C0
		private Color colorSelected; // 0x38
		[SerializeField] // 0x006171C0-0x006171D0
		private Color colorUnselected; // 0x48
		private int nowValue; // 0x58
		private int nowColumn; // 0x5C
	
		// Constructors
		public MenuSeedUI() {} // 0x00A0F2E0-0x00A0F2F0
	
		// Methods
		public override void SetInitialValue(int initialValue) {} // 0x00A0E8C0-0x00A0E8F0
		private void SetValueDigit(int value) {} // 0x00A0E8F0-0x00A0EAD0
		private int ChangeColumnDigit(int oldValue, int column, int digit) => default; // 0x00A0EAD0-0x00A0EB60
		private int GetColumnDigit(int value, int column) => default; // 0x00A0EBC0-0x00A0EC40
		private int GetColumnWeight(int column) => default; // 0x00A0EB60-0x00A0EBC0
		private void ColumnUP() {} // 0x00A0EC40-0x00A0EC70
		private void ColumnDOWN() {} // 0x00A0EC70-0x00A0EC90
		private void DigitUP() {} // 0x00A0EC90-0x00A0EDA0
		private void DigitDOWN() {} // 0x00A0EDA0-0x00A0EEB0
		private void Submit() {} // 0x00A0EEB0-0x00A0EF40
		private void Start() {} // 0x00A0EF40-0x00A0EF50
		private void Update() {} // 0x00A0EF50-0x00A0F2E0
	}
}
