/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class NamedGameFlowBlobListTbl // TypeDefIndex: 4686
{
	// Fields
	private List<GameFlowBlobList> List; // 0x10

	// Constructors
	public NamedGameFlowBlobListTbl() {} // 0x00E3ED10-0x00E3ED80

	// Methods
	public string SerializeHumanText(string indent) => default; // 0x00E3E170-0x00E3E2D0
	public bool DeserializeHumanText(ref Queue<string> lines) => default; // 0x00E3E2D0-0x00E3E3C0
	public bool TrySetupExecPointer(IGameFlowPlayable owner, GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00E3E3C0-0x00E3E4A0
	public void SetupExecPointer_NextFlowList(string name, IGameFlowPlayable owner, GameFlowPlayContext context) {} // 0x00E3E4A0-0x00E3E5B0
	public string TryGetExecPointer_ResumeFlowListName(IGameFlowPlayable owner, GameFlowPlayContext context) => default; // 0x00E3E5C0-0x00E3E650
	// [IteratorStateMachine] // 0x0061AB90-0x0061AC00
	public IEnumerator PlayAndClearExecPointerFlowList_ForSequence(IGameFlowPlayable owner, GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00E3E650-0x00E3E6D0
	public IGameFlowPlayable Find(Func<IGameFlowPlayable, bool> compFunc) => default; // 0x00E3E700-0x00E3E850
	public void Foreach(Action<IGameFlowPlayable> action) {} // 0x00E3E850-0x00E3E970
	public void Foreach(Stack<List<IGameFlowPlayable>> stack, Action<Stack<List<IGameFlowPlayable>>> action) {} // 0x00E3E970-0x00E3EAA0
	// [IteratorStateMachine] // 0x0061AC00-0x0061AC70
	public IEnumerable<GameFlowBlobList> EnumGameFlowBlobListTbl() => default; // 0x00E3EAA0-0x00E3EB20
	public bool ContainsName(string name) => default; // 0x00E3EB60-0x00E3EC30
	public GameFlowBlobList FindByName(string name) => default; // 0x00E3EC40-0x00E3ED00
}

