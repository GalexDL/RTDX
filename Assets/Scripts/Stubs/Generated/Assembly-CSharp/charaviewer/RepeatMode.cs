/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class RepeatMode : MonoBehaviour // TypeDefIndex: 8482
	{
		// Fields
		[SerializeField] // 0x00617570-0x00617580
		private Button buttonRepeatMode; // 0x18
		[SerializeField] // 0x00617580-0x00617590
		private Image buttonBackground; // 0x20
		[SerializeField] // 0x00617590-0x006175A0
		private Image buttonImage; // 0x28
		[SerializeField] // 0x006175A0-0x006175B0
		private BtnImage[] buttonImages; // 0x30
		[SerializeField] // 0x006175B0-0x006175C0
		private int defaultValue; // 0x38
		private int nowValue; // 0x3C
		private Action<int> callbackOnClick; // 0x40
	
		// Properties
		public int Mode { get => default; } // 0x00750150-0x00750160 
	
		// Nested types
		[Serializable]
		private class BtnImage // TypeDefIndex: 8483
		{
			// Fields
			public Color bgcol; // 0x10
			public Color color; // 0x20
	
			// Constructors
			public BtnImage() {} // 0x007502D0-0x007502E0
		}
	
		// Constructors
		public RepeatMode() {} // 0x007502C0-0x007502D0
	
		// Methods
		public void SetCallback(Action<int> callback) {} // 0x00750160-0x00750170
		public void SetMode(int mode) {} // 0x00750170-0x00750180
		public void OnClickButton() {} // 0x00750270-0x007502A0
		private void UpdateImage() {} // 0x00750180-0x00750270
		private void Start() {} // 0x007502A0-0x007502B0
		private void Update() {} // 0x007502B0-0x007502C0
	}
}
