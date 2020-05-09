/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GameFlowBlobList // TypeDefIndex: 4684
{
	// Fields
	public bool IsUseName; // 0x10
	public string Name; // 0x18
	public List<GameFlowBlobBase> List; // 0x20
	private static Regex match_Name; // 0x00
	private static Regex match_Type; // 0x08

	// Constructors
	public GameFlowBlobList() {} // 0x00BB3010-0x00BB3090
	static GameFlowBlobList() {} // 0x00BB3090-0x00BB3140

	// Methods
	public string SerializeHumanText(string indent) => default; // 0x00BB21F0-0x00BB24A0
	public bool DeserializeHumanText(ref Queue<string> lines) => default; // 0x00BB24A0-0x00BB2980
	public bool TrySetupExecPointer(IGameFlowPlayable owner, GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00BB2980-0x00BB2AD0
	// [IteratorStateMachine] // 0x0061AB20-0x0061AB90
	public IEnumerator Play_ForSequence(IGameFlowPlayable owner, GameFlowPlayContext context, Func<bool> needExit, Func<bool> seqStop) => default; // 0x00BB2AD0-0x00BB2B60
	public IGameFlowPlayable Find(Func<IGameFlowPlayable, bool> compFunc) => default; // 0x00BB2B90-0x00BB2CE0
	public void Foreach(Action<IGameFlowPlayable> action) {} // 0x00BB2CE0-0x00BB2E10
	public void Foreach(Stack<List<IGameFlowPlayable>> stack, Action<Stack<List<IGameFlowPlayable>>> action) {} // 0x00BB2E10-0x00BB3010
}

