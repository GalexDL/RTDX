/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace wazaviewer
{
	public class MenuSelectController : MonoBehaviour // TypeDefIndex: 8447
	{
		// Fields
		[SerializeField] // 0x00616E30-0x00616E80
		// [Tooltip] // 0x00616E30-0x00616E80
		private UIControlTMP uiControlTMP; // 0x18
		private MenuItemModel itemModel; // 0x20
		private Action<MenuItemModel, Action<int>> funcDialog; // 0x28
	
		// Constructors
		public MenuSelectController() {} // 0x00B02B10-0x00B02B20
	
		// Methods
		public void SetMenuItemModel(MenuItemModel itemModel, Action<MenuItemModel, Action<int>> funcDialog) {} // 0x00B02330-0x00B023B0
		private void UpdateLabel() {} // 0x00B023B0-0x00B02440
		public void OnClickNext() {} // 0x00B02440-0x00B024F0
		public void OnClickPrev() {} // 0x00B025A0-0x00B02650
		public void OnClickNextSkip10() {} // 0x00B02700-0x00B027B0
		public void OnClickPrevSkip10() {} // 0x00B027B0-0x00B02860
		public void OnClickNextSkip100() {} // 0x00B02860-0x00B02910
		public void OnClickPrevSkip100() {} // 0x00B02910-0x00B029C0
		public void OpenFilterDialog() {} // 0x00B029C0-0x00B02A80
		public void OnNextItem() {} // 0x00B024F0-0x00B025A0
		public void OnPrevItem() {} // 0x00B02650-0x00B02700
		public void OnNowItem() {} // 0x00B02A80-0x00B02B10
	}
}
