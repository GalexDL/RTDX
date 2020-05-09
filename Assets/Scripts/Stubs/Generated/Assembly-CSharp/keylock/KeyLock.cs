/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace keylock
{
	public class KeyLock : MonoBehaviour // TypeDefIndex: 8448
	{
		// Fields
		[SerializeField] // 0x00616E80-0x00616ED0
		// [Tooltip] // 0x00616E80-0x00616ED0
		private Text numberPanel; // 0x18
		[SerializeField] // 0x00616ED0-0x00616F20
		// [Tooltip] // 0x00616ED0-0x00616F20
		private Button[] numberButton; // 0x20
		[SerializeField] // 0x00616F20-0x00616F70
		// [Tooltip] // 0x00616F20-0x00616F70
		private Button clearButton; // 0x28
		[SerializeField] // 0x00616F70-0x00616FC0
		// [Tooltip] // 0x00616F70-0x00616FC0
		private Button backspaceButton; // 0x30
		[SerializeField] // 0x00616FC0-0x00617010
		// [Tooltip] // 0x00616FC0-0x00617010
		private Transform cursorObject; // 0x38
		[SerializeField] // 0x00617010-0x00617060
		// [Tooltip] // 0x00617010-0x00617060
		private float cursorMove; // 0x40
		[SerializeField] // 0x00617060-0x006170B0
		// [Tooltip] // 0x00617060-0x006170B0
		private int maxColumn; // 0x44
		[SerializeField] // 0x006170B0-0x00617100
		// [Tooltip] // 0x006170B0-0x00617100
		private string correctAnswer; // 0x48
		private char[] numberBuffer; // 0x50
		private int numCounter; // 0x58
		private InputPhase phase; // 0x5C
		private int cursorX; // 0x60
		private int cursorY; // 0x64
		private Action finishAction; // 0x68
		private KeyCode[] numPad; // 0x70
		private bool isReleaseWait; // 0x78
		private KeyCode lastKeyCode; // 0x7C
	
		// Nested types
		private enum InputPhase // TypeDefIndex: 8449
		{
			WAIT = 0,
			OK = 1,
			NG = 2
		}
	
		// Constructors
		public KeyLock() {} // 0x00A0DA40-0x00A0DAD0
	
		// Methods
		public void SetFinishProcess(Action func) {} // 0x00A0CF70-0x00A0CF80
		private void Start() {} // 0x00A0CF80-0x00A0D020
		private void Update() {} // 0x00A0D020-0x00A0D1C0
		private void OKPhase() {} // 0x00A0D1F0-0x00A0D200
		private void NGPhase() {} // 0x00A0D200-0x00A0D2A0
		private void HIDInput() {} // 0x00A0D1C0-0x00A0D1F0
		private void KeyboardInput() {} // 0x00A0D340-0x00A0D550
		private void GamePadInput() {} // 0x00A0D550-0x00A0D8A0
		public void OnClickNumber(int number) {} // 0x00A0D8A0-0x00A0D9B0
		public void OnClickClear() {} // 0x00A0D2A0-0x00A0D340
		public void OnClickBackspace() {} // 0x00A0D9B0-0x00A0DA40
	}
}
