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
	public class ChangeLogController : MonoBehaviour, ChangeLogItem.ILogItemCallback // TypeDefIndex: 8484
	{
		// Fields
		[SerializeField] // 0x006175C0-0x00617610
		// [Tooltip] // 0x006175C0-0x00617610
		private GameObject prefabItem; // 0x18
		[SerializeField] // 0x00617610-0x00617660
		// [Tooltip] // 0x00617610-0x00617660
		private ScrollViewManager scrollView; // 0x20
		private RevisionData revisionData; // 0x28
		private Action finishProcess; // 0x30
	
		// Nested types
		private delegate bool ShowFunc(RevisionData.Item item); // TypeDefIndex: 8485; 0x00749250-0x007497E0
	
		// Constructors
		public ChangeLogController() {} // 0x007499E0-0x007499F0
	
		// Methods
		private void CreateItem(RevisionData.Item revItem) {} // 0x00748270-0x00748420
		public void SetFinishProcess(Action finishProcess) {} // 0x00748830-0x00748840
		private void Start() {} // 0x00748840-0x00748A90
		private void Update() {} // 0x007490D0-0x007490E0
		public void OnClickFinish() {} // 0x007490E0-0x007490F0
		public void OnChangeFilter(int filterMode) {} // 0x00748EB0-0x007490D0
		private void SetFilter(ShowFunc func) {} // 0x00749100-0x00749250
		void changelog.ChangeLogItem.ILogItemCallback.OnClickItem(LinkedListNode<GameObject> node) {} // 0x00749990-0x007499A0
		void changelog.ChangeLogItem.ILogItemCallback.OnDragPointer(Vector2 move) {} // 0x007499A0-0x007499C0
	}
}
