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
	public class MenuItemController : MonoBehaviour // TypeDefIndex: 8471
	{
		// Fields
		[SerializeField] // 0x006174A0-0x006174B0
		private Text textLabel; // 0x18
		[SerializeField] // 0x006174B0-0x006174C0
		private Text textItem; // 0x20
		[SerializeField] // 0x006174C0-0x006174D0
		private Button[] buttonPrev; // 0x28
		[SerializeField] // 0x006174D0-0x006174E0
		private Button[] buttonNext; // 0x30
		[SerializeField] // 0x006174E0-0x006174F0
		private Color selectedColor; // 0x38
		[SerializeField] // 0x006174F0-0x00617500
		private Color unselectedColor; // 0x48
		[SerializeField] // 0x00617500-0x00617510
		private int delayFrames; // 0x58
		private int delayCounter; // 0x5C
		private bool isDelayReserve; // 0x60
		private float ClickTime; // 0x64
		private const float DOUBLE_CLICK_TIME = 0.3f; // Metadata: 0x00614B71
		private Action ExecDoubleClick; // 0x68
		private bool isSelect; // 0x70
		private MenuItemModel menuListener; // 0x78
		private IMenuItemSelector selector; // 0x80
		private int index; // 0x88
		private int itemIndex; // 0x98
		private Action<int> updateCallback; // 0xA0
	
		// Properties
		public bool IsSelect { get => default; set {} } // 0x0074E390-0x0074E3A0 0x0074D2E0-0x0074D450
		public string Name { get; private set; } // 0x0074E3A0-0x0074E3B0 0x0074E3B0-0x0074E3C0
	
		// Nested types
		public interface IMenuItemSelector // TypeDefIndex: 8472
		{
			// Methods
			void OnSelectLine(int index);
		}
	
		// Constructors
		public MenuItemController() {} // 0x0074F1D0-0x0074F1E0
	
		// Methods
		public void SetMenuItem(string label, MenuItemModel menuItem, int itemIndex = 0 /* Metadata: 0x00614B6B */, Action<int> updateCallback = null, Action doubleClick = null) {} // 0x0074E3C0-0x0074E580
		public void SetSelector(IMenuItemSelector selector, int index) {} // 0x0074D4F0-0x0074D500
		public int GetSelectorIndex() => default; // 0x0074D5A0-0x0074D5C0
		private void Start() {} // 0x0074E5A0-0x0074E630
		private void Update() {} // 0x0074E6D0-0x0074E710
		private void SetupInitialMenu(bool isReportInitialize = true /* Metadata: 0x00614B6F */) {} // 0x0074E630-0x0074E6D0
		private void OnSelect() {} // 0x0074E960-0x0074E9E0
		public void NextValue() {} // 0x0074D6B0-0x0074D740
		public void PrevValue() {} // 0x0074D830-0x0074D8C0
		public void NextSkip(int num) {} // 0x0074D9C0-0x0074DA90
		public void PrevSkip(int num) {} // 0x0074DC90-0x0074DD70
		public void OnLeftButton() {} // 0x0074E9E0-0x0074EAB0
		public void OnRightButton() {} // 0x0074EB20-0x0074EBF0
		public void OnLeft10Button() {} // 0x0074EBF0-0x0074ECF0
		public void OnRight10Button() {} // 0x0074ECF0-0x0074EDF0
		public void OnLeft100Button() {} // 0x0074EDF0-0x0074EEF0
		public void OnRight100Button() {} // 0x0074EEF0-0x0074EFF0
		private void SetSideButton() {} // 0x0074E710-0x0074E920
		public void Reset(bool isReport = true /* Metadata: 0x00614B70 */) {} // 0x0074EFF0-0x0074F090
		public void SelectIndex(int index, bool isUpdate) {} // 0x0074F090-0x0074F130
		public void OnDoubleClickLine() {} // 0x0074F130-0x0074F1D0
		private void OnClickLine() {} // 0x0074EAB0-0x0074EB20
		private void OnSelectItem() {} // 0x0074E920-0x0074E960
	}
}
