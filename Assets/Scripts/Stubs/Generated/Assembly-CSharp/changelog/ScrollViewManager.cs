/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace changelog
{
	public class ScrollViewManager : MonoBehaviour // TypeDefIndex: 8491
	{
		// Fields
		[SerializeField] // 0x006176D0-0x00617720
		// [Tooltip] // 0x006176D0-0x00617720
		private RectTransform targetContent; // 0x18
		private float heightContent; // 0x20
		private float nextPosition; // 0x24
		private LinkedList<GameObject> listItems; // 0x28
		private float scrollSpeed; // 0x30
	
		// Constructors
		public ScrollViewManager() {} // 0x0074AC80-0x0074ACF0
	
		// Methods
		public LinkedListNode<GameObject> AddItem(GameObject item) => default; // 0x007486F0-0x00748820
		public void RemoveItem(LinkedListNode<GameObject> itemNode) {} // 0x0074A680-0x0074A840
		public LinkedListNode<GameObject> InsertItem(LinkedListNode<GameObject> pointItem, GameObject item) => default; // 0x0074A840-0x0074AA60
		public void SetItemActive(LinkedListNode<GameObject> itemNode, bool isActive) {} // 0x007497E0-0x00749990
		public void Clear() {} // 0x0074AA60-0x0074AB90
		public void MoveScroll(float move) {} // 0x007499C0-0x007499E0
		private void Start() {} // 0x0074AB90-0x0074ABA0
		private void Update() {} // 0x0074ABA0-0x0074AC80
	}
}
