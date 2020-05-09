/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace charaviewer
{
	public class MenuRewritableItemModel<T> : MenuItemModel // TypeDefIndex: 8475
	{
		// Fields
		private bool isLoop; // 0x00
		private ICollection<T> itemCollection; // 0x00
		private bool isNotExistItem; // 0x00
		private T[] itemArray; // 0x00
		private Action<int, T> callback; // 0x00
		private Action<int, T> delayCallback; // 0x00
		private ToLabel labelFilter; // 0x00
		private int nowIndex; // 0x00
		private bool isSkipByCount; // 0x00
		private bool isForceSkip10; // 0x00
		private bool isForceSkip100; // 0x00
	
		// Properties
		public override bool isExistNext { get => default; }
		public override bool isExistPrev { get => default; }
		public override bool isShowSkip10 { get => default; }
		public override bool isShowSkip100 { get => default; }
	
		// Nested types
		public delegate string ToLabel(int index, T item); // TypeDefIndex: 8476; 0x00000000-0x00000000
	
		// Constructors
		public MenuRewritableItemModel() {} // Dummy constructor
		public MenuRewritableItemModel(ToLabel labelFilter, Action<int, T> callback, Action<int, T> delayCallback = null, bool isLoop = true /* Metadata: 0x00614B76 */, bool isForceSkip10 = false /* Metadata: 0x00614B77 */, bool isForceSkip100 = false /* Metadata: 0x00614B78 */, bool isSkipByCount = true /* Metadata: 0x00614B79 */) {}
	
		// Methods
		public override void Initialize() {}
		public override string GetCurrent() => default;
		public override string GetNext() => default;
		public override string GetPrev() => default;
		public override string GetSkipNext(int num) => default;
		public override string GetSkipPrev(int num) => default;
		public override void OnSelectItem() {}
		public override void OnDelayItemSelect() {}
		protected override int GetSelectedIndex() => default;
		public override bool SelectIndex(int index) => default;
		public bool IsEnable() => default;
		public void RewriteItemCollection(ICollection<T> itemCollection, bool isReport = true /* Metadata: 0x00614B7A */) {}
		public T GetItemByIndex(int index) => default;
		public int SelectNearItem(string label) => default;
	}
}
