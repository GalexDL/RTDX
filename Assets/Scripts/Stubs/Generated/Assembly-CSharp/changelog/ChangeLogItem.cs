/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace changelog
{
	public class ChangeLogItem : MonoBehaviour // TypeDefIndex: 8487
	{
		// Fields
		[SerializeField] // 0x00617660-0x006176B0
		// [Tooltip] // 0x00617660-0x006176B0
		private Text targetText; // 0x18
		private LinkedListNode<GameObject> selfNode; // 0x20
		private ILogItemCallback listener; // 0x28
		private bool isDragItem; // 0x30
		private Vector2 prePosition; // 0x34
	
		// Nested types
		public interface ILogItemCallback // TypeDefIndex: 8488
		{
			// Methods
			void OnClickItem(LinkedListNode<GameObject> node);
			void OnDragPointer(Vector2 move);
		}
	
		// Constructors
		public ChangeLogItem() {} // 0x0074A460-0x0074A4E0
	
		// Methods
		public void SetListener(LinkedListNode<GameObject> node, ILogItemCallback listener) {} // 0x00748820-0x00748830
		public void SetText(string message) {} // 0x00748460-0x007486F0
		public void OnClickItem() {} // 0x00749DF0-0x00749FC0
		public void OnPointerDown(BaseEventData data) {} // 0x00749FC0-0x0074A060
		public void OnDragPointer(BaseEventData data) {} // 0x0074A060-0x0074A310
		public void OnPointerUp(BaseEventData data) {} // 0x0074A310-0x0074A460
	}
}
