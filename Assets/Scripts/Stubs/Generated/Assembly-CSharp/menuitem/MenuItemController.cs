/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace menuitem
{
	public class MenuItemController : MonoBehaviour // TypeDefIndex: 8455
	{
		// Fields
		[SerializeField] // 0x00617100-0x00617110
		private UIControlTMP labelText; // 0x18
		[SerializeField] // 0x00617110-0x00617120
		private Button buttonPrev; // 0x20
		[SerializeField] // 0x00617120-0x00617130
		private Button buttonNext; // 0x28
		[SerializeField] // 0x00617130-0x00617140
		private int delayTime; // 0x30
		[SerializeField] // 0x00617140-0x00617150
		private Color colorSelected; // 0x34
		[SerializeField] // 0x00617150-0x00617160
		private Color colorUnselected; // 0x44
		private MenuItemModel model; // 0x58
		private int timeCount; // 0x60
	
		// Constructors
		public MenuItemController() {} // 0x00A0E610-0x00A0E620
	
		// Methods
		public void SetModel(MenuItemModel model) {} // 0x00A0DFC0-0x00A0DFD0
		public void SelectMode(bool isSelect) {} // 0x00A0DFD0-0x00A0E090
		public void OnClickNext() {} // 0x00A0E090-0x00A0E100
		public void OnClickPrev() {} // 0x00A0E170-0x00A0E1E0
		public void NextValue(int mag = 1 /* Metadata: 0x00614B4E */) {} // 0x00A0E100-0x00A0E170
		public void PrevValue(int mag = 1 /* Metadata: 0x00614B52 */) {} // 0x00A0E1E0-0x00A0E250
		private void UpdateLabel() {} // 0x00A0E2A0-0x00A0E350
		private void NewSelect() {} // 0x00A0E250-0x00A0E2A0
		public void OpenSubDialog(Transform parent, Action finishCallback) {} // 0x00A0E350-0x00A0E530
		private void Start() {} // 0x00A0E550-0x00A0E5B0
		private void Update() {} // 0x00A0E5B0-0x00A0E610
	}
}
