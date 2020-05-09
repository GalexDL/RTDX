/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public abstract class GameFlowBlobBase : IGameFlowPlayable // TypeDefIndex: 4697
{
	// Fields
	private ScenarioProgressType progressType_; // 0x10

	// Properties
	public virtual string FlowId { get; set; } // 0x00BB12A0-0x00BB12B0 0x00BB12B0-0x00BB12C0
	public string DebugMenuName { get; } // 0x00BB12C0-0x00BB1310 
	public virtual string DebugMenuNameRaw { get; } // 0x00BB14C0-0x00BB14D0 
	public virtual string DebugMenuNameTextId { get; set; } // 0x00BB14D0-0x00BB14E0 0x00BB14E0-0x00BB14F0
	public ScenarioProgressType ProgressType { get; set; } // 0x00BB15A0-0x00BB15B0 0x00BB15B0-0x00BB15C0
	public int ProgressNo { get; set; } // 0x00BB15C0-0x00BB15D0 0x00BB15D0-0x00BB15E0

	// Constructors
	protected GameFlowBlobBase() {} // 0x00BB1670-0x00BB1680

	// Methods
	public virtual string SerializeHumanText(string indent) => default; // 0x00BB0F90-0x00BB1030
	public virtual void DeserializeHumanText(ref Queue<string> lines) {} // 0x00BB1030-0x00BB10A0
	public virtual bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00BB10A0-0x00BB10B0
	// [IteratorStateMachine] // 0x0061AC70-0x0061ACE0
	public virtual IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BB10B0-0x00BB1110
	public virtual IGameFlowPlayable Find(Func<IGameFlowPlayable, bool> compFunc) => default; // 0x00BB1140-0x00BB11B0
	public virtual void Foreach(Action<IGameFlowPlayable> action) {} // 0x00BB11B0-0x00BB1210
	public virtual void Foreach(Stack<List<IGameFlowPlayable>> stack, Action<Stack<List<IGameFlowPlayable>>> action) {} // 0x00BB1210-0x00BB12A0
	public static string GenDebugMenuText(string id, string rawText) => default; // 0x00BB1310-0x00BB14C0
	// [IteratorStateMachine] // 0x0061ACE0-0x0061AD50
	public virtual IEnumerable<GameFlowBlobList> EnumOwnGameFlowBlobListTbl() => default; // 0x00BB14F0-0x00BB1560
	public void ApplyProgressNo() {} // 0x00BB15E0-0x00BB1670
}

