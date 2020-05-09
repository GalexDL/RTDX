/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GameFlowData : MonoBehaviour, ISerializeDataText, IGameFlowPlayable // TypeDefIndex: 4663
{
	// Fields
	[NonSerialized]
	public string FlowDataName; // 0x18
	public GameFlowBlobList BlobList; // 0x20

	// Properties
	public virtual string FlowId { get => default; set {} } // 0x00A5D940-0x00A5D9A0 0x00A5D9A0-0x00A5D9B0
	public string SerializedDataText { get => default; set {} } // 0x00A5D9B0-0x00A5DA10 0x00A5DA70-0x00A5DA80

	// Constructors
	public GameFlowData() {} // 0x00A5DF50-0x00A5DFD0

	// Methods
	public bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00A5D5D0-0x00A5D5F0
	// [IteratorStateMachine] // 0x0061A8F0-0x0061A960
	public IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00A5D5F0-0x00A5D670
	public IGameFlowPlayable Find(Func<IGameFlowPlayable, bool> compFunc) => default; // 0x00A5D6A0-0x00A5D730
	public void Foreach(Action<IGameFlowPlayable> action) {} // 0x00A5D730-0x00A5D7A0
	public void Foreach(Stack<List<IGameFlowPlayable>> stack, Action<Stack<List<IGameFlowPlayable>>> action) {} // 0x00A5D7A0-0x00A5D880
	// [IteratorStateMachine] // 0x0061A960-0x0061A9D0
	public IEnumerable<GameFlowBlobList> EnumOwnGameFlowBlobListTbl() => default; // 0x00A5D880-0x00A5D900
	private string SerializeHumanText_() => default; // 0x00A5DA10-0x00A5DA70
	private void DeserializeHumanText_(string serializedDataText) {} // 0x00A5DA80-0x00A5DB40
	private void OnAfterDeserializeHumanText_() {} // 0x00A5DD80-0x00A5DF50
}

