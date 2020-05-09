/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dictionary;
using Const.dictionaryCategory;
using Const.waza;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DictionaryMenuTool : Singleton<DictionaryMenuTool> // TypeDefIndex: 6215
{
	// Fields
	private Dictionary<Const.dictionary.Index, DictionaryData> dictionaryDataList; // 0x10
	private Const.waza.Index[] wazaIndices; // 0x18

	// Properties
	public Dictionary<Const.dictionary.Index, DictionaryData> DictionaryDataList { get => default; } // 0x00994AF0-0x00994B00 

	// Nested types
	public class DictionaryData // TypeDefIndex: 6216
	{
		// Fields
		private Const.dictionaryCategory.Index categoryIndex; // 0x10
		private uint itemIndex; // 0x14
		private string displayProgress; // 0x18
		private uint sortKey; // 0x20
		private string[] itemNameCache_; // 0x28
		private string pureNameCache_; // 0x30
		private string itemExpCache_; // 0x38

		// Properties
		public Const.dictionaryCategory.Index CategoryIndex { get => default; set {} } // 0x009951F0-0x00995200 0x00994FE0-0x00994FF0
		public uint ItemIndex { get => default; set {} } // 0x00995420-0x00995430 0x00994FF0-0x00995000
		public string DisplayProgress { get => default; set {} } // 0x00995430-0x00995440 0x00995010-0x00995020
		public uint SortKey { get => default; set {} } // 0x00995440-0x00995450 0x00995000-0x00995010

		// Constructors
		public DictionaryData() {} // 0x00994F80-0x00994FE0

		// Methods
		public string GetItemName(bool bPlural = false /* Metadata: 0x00612AA7 */) => default; // 0x00995450-0x009956F0
		public string GetPureItemName() => default; // 0x009956F0-0x00995880
		public string GetItemExplanation() => default; // 0x00995880-0x00995CE0
		public bool IsCanDisplay() => default; // 0x00995CE0-0x00995D60
	}

	// Constructors
	public DictionaryMenuTool() {} // 0x00995380-0x00995420

	// Methods
	public uint GetLinkHash(Const.dictionary.Index index) => default; // 0x00994A80-0x00994AF0
	public void DictionaryClear() {} // 0x00994B00-0x00994B60
	public Dictionary<Const.dictionary.Index, DictionaryData> CreateDefaultList() => default; // 0x00994B60-0x00994F80
	public DictionaryData CreateHashToData(uint hash) => default; // 0x00995020-0x009951F0
	private Const.waza.Index IndexAdjust(Const.waza.Index index) => default; // 0x00995340-0x00995380
	public uint GetLinkHash_WazaAdjust(uint hash) => default; // 0x00995200-0x00995340
}

