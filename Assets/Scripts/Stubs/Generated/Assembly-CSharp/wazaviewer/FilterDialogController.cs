/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace wazaviewer
{
	public class FilterDialogController : MonoBehaviour // TypeDefIndex: 8436
	{
		// Fields
		[SerializeField] // 0x00616D20-0x00616D30
		private UIControlTMP[] topLayerItem; // 0x18
		[SerializeField] // 0x00616D30-0x00616D40
		private UIControlTMP[] selectedItem; // 0x20
		[SerializeField] // 0x00616D40-0x00616D50
		private UIControlTMP selectedTitle; // 0x28
		[SerializeField] // 0x00616D50-0x00616D60
		private GameObject objTopLayer; // 0x30
		[SerializeField] // 0x00616D60-0x00616D70
		private GameObject obj2ndLayer; // 0x38
		[SerializeField] // 0x00616D70-0x00616D80
		private Color colorSelected; // 0x40
		[SerializeField] // 0x00616D80-0x00616D90
		private Color colorUnselected; // 0x50
		private Filter[][] initialCharacterList; // 0x60
		private MenuItemModel itemModel; // 0x68
		private int pageNumberTop; // 0x70
		private int cursorTopIndex; // 0x74
		private int maxTopItem; // 0x78
		private List<Item[]> itemPages; // 0x80
		private int pageNumber2nd; // 0x88
		private int cursor2ndIndex; // 0x8C
		private int max2ndItem; // 0x90
		private Action<bool, int> selectCallback; // 0x98
		private Status nowStatus; // 0xA0
	
		// Nested types
		private class Filter // TypeDefIndex: 8437
		{
			// Properties
			public TextIDHash textId { get; private set; } // 0x00AF8C40-0x00AF8C50 0x00B01BD0-0x00B01BE0
			public string[] hitInitial { get; private set; } // 0x00AF9030-0x00AF9040 0x00B01BE0-0x00B01BF0
			public bool bNotHit { get; private set; } // 0x00AF9040-0x00AF9050 0x00B01BF0-0x00B01C00
	
			// Constructors
			public Filter() {} // Dummy constructor
			public Filter(TextIDHash textId, string[] hitInitial, bool bIgnore = false /* Metadata: 0x00614B31 */) {} // 0x00B01B80-0x00B01BD0
		}
	
		private class Item // TypeDefIndex: 8438
		{
			// Properties
			public int Index { get; private set; } // 0x00AF9900-0x00AF9910 0x00B01C00-0x00B01C10
			public string Label { get; private set; } // 0x00AF92A0-0x00AF92B0 0x00B01C10-0x00B01C20
	
			// Constructors
			public Item() {} // Dummy constructor
			public Item(int index, string label) {} // 0x00AF9050-0x00AF9090
		}
	
		private enum Status // TypeDefIndex: 8439
		{
			LAYER_TOP = 0,
			LAYER_2ND = 1,
			FINISH = 2
		}
	
		// Constructors
		public FilterDialogController() {} // 0x00AF9910-0x00B01B80
	
		// Methods
		public void SetItemModel(MenuItemModel itemModel, Action<bool, int> selectCallback) {} // 0x00AF8AC0-0x00AF8AD0
		private void UpdateTopPage() {} // 0x00AF8AD0-0x00AF8C40
		private void CursorTopPage() {} // 0x00AF8C50-0x00AF8DA0
		private void Open2ndLayer(Filter filter) {} // 0x00AF8DA0-0x00AF9030
		private void Update2ndPage() {} // 0x00AF9090-0x00AF92A0
		private void Cursor2ndPage() {} // 0x00AF92B0-0x00AF9400
		private void Start() {} // 0x00AF9400-0x00AF9450
		private void Update() {} // 0x00AF9450-0x00AF9550
		private void UpdateLayerTop(uint trigger) {} // 0x00AF9550-0x00AF9730
		private void UpdateLayer2nd(uint trigger) {} // 0x00AF9730-0x00AF9900
	}
}
